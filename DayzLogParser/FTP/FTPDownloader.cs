using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DayzLogParser.FTP {

    public delegate void ProgressUpdated(long current, long length, double speed);
    public delegate void DownloadStopped();
    public delegate void DownloadFinished(String filePath);
    public delegate void DownloadFailed(int code, String reason);

    public class FTPDownloader {
        public String ip { get; private set; }
        public NetworkCredential credentials { get; private set; }
        public ProgressUpdated progressUpdatedListeners { get; set; }
        public DownloadStopped downloadStoppedListeners { get; set; }
        public DownloadFinished downloadFinishedListeners { get; set; }
        public DownloadFailed downloadFailedListeners { get; set; }


        public long currentProgress { get; set; }
        public long length { get; set; }

        public String response { get; set; }

        private Boolean _stopped { get; set; }

        public FTPDownloader(String ip, NetworkCredential credentials) {
            this.ip = ip;
            // new NetworkCredential("anonymous", "janeDoe@contoso.com");
            this.credentials = credentials;
        }

        /// <summary>
        /// Stops this download, and cleans up the class.
        /// </summary>
        public void StopDownload() {
            this._stopped = true;
        }

        /// <summary>
        /// Cleans this instance up from responses etc.
        /// </summary>
        private void Cleanup() {
            this.length = 0;
            this.currentProgress = 0;
            this.response = "";
            this.progressUpdatedListeners = null;
            this._stopped = false;
        }

        /// <summary>
        /// Starts the FTP download of a file.
        /// </summary>
        /// <param name="filePath">The filepath (including filename!) leading to what file to download.</param>
        public virtual void StartDownload(String filePath) {
            this.length = this.GetFileSize(filePath);

            if (this.length == 0) {
                this.downloadFailedListeners(2, "Unable to fetch filesize. Check FTP settings.");
                return;
            }

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(this.ip + filePath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.UsePassive = true;

            // This assumes the FTP site uses normal logon.
            request.Credentials = this.credentials;
            request.ContentLength = 0;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            System.IO.Directory.CreateDirectory(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory + filePath));
            String fullFilePath = AppDomain.CurrentDomain.BaseDirectory + filePath;
            FileStream file = File.Create(fullFilePath);

            byte[] buffer = new byte[32 * 1024];
            int read = 0;

            // Initialize some variables to keep track of speed
            double currSpeed = 0;
            double currTime = 0;
            double lastSpeedUpdate = 0;
            double bytesDownloadedSinceLastUpdate = 0;
            int speedUpdateMS = 1000;
            while (!_stopped && (read = responseStream.Read(buffer, 0, buffer.Length)) > 0) {

                // If we need to update the speed
                if ((currTime = new TimeSpan(DateTime.UtcNow.Ticks).TotalMilliseconds) - lastSpeedUpdate > speedUpdateMS) {
                    lastSpeedUpdate = currTime;
                    currSpeed = bytesDownloadedSinceLastUpdate;
                    bytesDownloadedSinceLastUpdate = 0;
                }

                file.Write(buffer, 0, read);

                this.currentProgress += read;
                // Track how many bytes downloaded this second
                bytesDownloadedSinceLastUpdate += read;

                this.progressUpdatedListeners(this.currentProgress, this.length, currSpeed);
            }

            #region Check if was stopped and handle
            if (_stopped) {

                try {
                    response.Close();
                    responseStream.Close();
                    file.Close();
                    this.Cleanup();
                } catch (Exception e) {

                } finally {
                    if (response != null)
                        response.Close();
                    if (responseStream != null)
                        responseStream.Close();
                    if (file != null)
                        file.Close();
                    this.Cleanup();
                }

                this.downloadStoppedListeners();

                return;
            }
            #endregion

            Console.WriteLine("Download Complete, status {0}", response.StatusDescription);

            file.Close();
            response.Close();
            responseStream.Close();

            this.downloadFinishedListeners(fullFilePath);
        }

        /// <summary>
        /// Gets the file size of a file.
        /// </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>The file size in bytes. If 0, no file was found.</returns>
        public long GetFileSize(String filePath) {
            try {
                FtpWebRequest sizeRequest = (FtpWebRequest)WebRequest.Create(this.ip + filePath);

                sizeRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                sizeRequest.Credentials = this.credentials;

                FtpWebResponse loginresponse = (FtpWebResponse)sizeRequest.GetResponse();
                FtpWebResponse respSize = (FtpWebResponse)sizeRequest.GetResponse();
                respSize = (FtpWebResponse)sizeRequest.GetResponse();
                long size = respSize.ContentLength;

                respSize.Close();

                return size;
            } catch (WebException e) {
                this.downloadFailedListeners(1, e.Message);
            }
            
            return 0;
        }
    }
}

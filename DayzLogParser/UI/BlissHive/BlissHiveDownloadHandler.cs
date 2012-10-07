using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Settings;
using System.Net;
using DayzLogParser.Settings.BlissHive;
using System.Windows.Forms;
using DayzLogParser.FTP;
using DayzLogParser.Log.BlissHive;
using DayzLogParser.Log;
using System.ComponentModel;

namespace DayzLogParser.UI.BlissHive {
    public class BlissHiveDownloadHandler : LogDownloadHandler {

        public BlissHiveDownloadHandler(DayzLogParserForm dayzLogParserForm)
            : base(dayzLogParserForm) {

        }

        public override void StartDownload() {
            LinkedList<SettingsCategory> categories =
                SettingsController.GetInstance().LoadSettingsFile(OptionsForm.SettingsFileLocation);

            Boolean foundSettings = false;
            String IP = "";
            String port = "";
            String rootFolder = "";
            NetworkCredential credential = null;// new NetworkCredential();
            foreach (SettingsCategory category in categories) {
                if (category is FTPSettingsCategory) {
                    FTPSettingsCategory ftpCategory = (FTPSettingsCategory)category;

                    IP = ftpCategory.ip;
                    port = ftpCategory.port;
                    credential = new NetworkCredential(ftpCategory.username, ftpCategory.password);
                    rootFolder = ftpCategory.rootFolder;

                    foundSettings = true;
                }
            }

            if (foundSettings) {
                int errors = 0;
                if (IP.Length == 0) {
                    MessageBox.Show("IP not set. See Options to set an IP.");
                    errors++;
                }
                int portInt = 0;
                if (port.Length == 0 && !Int32.TryParse(port, out portInt)) {
                    MessageBox.Show("Port not set or invalid. See Options to set a valid port.");
                    errors++;
                }
                if (credential.UserName.Length == 0) {
                    MessageBox.Show("Username not set. See Options to set a username.");
                    errors++;
                }
                if (credential.Password.Length == 0) {
                    MessageBox.Show("Password not set. See Options to set a password.");
                    errors++;
                }

                if (errors == 0) {
                    // try {
                    FTPController.GetInstance().blissHiveDownloader =
                        new LogFileDownloader(IP, port, credential, rootFolder, LogFileDownloader.LogFile.BlissHive);
                    FTPController.GetInstance().blissHiveDownloader.progressUpdatedListeners += this.OnDownloadProgress;
                    FTPController.GetInstance().blissHiveDownloader.downloadStoppedListeners += this.CancelDownload;
                    FTPController.GetInstance().blissHiveDownloader.downloadFinishedListeners += this.FinishedDownload;
                    FTPController.GetInstance().blissHiveDownloader.downloadFailedListeners += this.FailedDownload;

                    this.dayzLogParserForm.SetStatusText(0, "Downloading blisshive.log..");
                    this.dayzLogParserForm.SetStatusText(1, "");
                    this.dayzLogParserForm.blissHiveDownloadLogBtn.Text = "Stop";
                    /*} catch(WebException e){

                    }*/
                }
            } else {
                MessageBox.Show("No FTP Settings found. Please add them in the Options menu.");
            }

        }


        /// <summary>
        /// Clears the progressbar, and invokes if needed.
        /// </summary>
        public void ClearProgressBar() {
            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { ClearProgressBar(); }));
            } else {
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Minimum = 0;
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Maximum = 1;
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Value = 0;
                this.dayzLogParserForm.SetStatusText(0, "");
                this.dayzLogParserForm.SetStatusText(1, "");
            }
        }

        /// <summary>
        /// Called when the blisshive download progress should be updated.
        /// </summary>
        /// <param name="current">The current progress.</param>
        /// <param name="length">The maximum progress</param>
        public override void OnDownloadProgress(long current, long length, double speed) {

            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { OnDownloadProgress(current, length, speed); }));
            } else {
                String[] abbreviations = new String[] { "B/s", "KB/s", "MB/s", "GB/s", "TB/s", "PB/s" };
                String speedText = "";

                for (int i = 0; i < abbreviations.Length; i++) {
                    if (speed > 1024) {
                        speed /= 1024f;
                    } // Check if someone downloads with more than 1024 PB/s .. holy shit
                    else if (speed <= 1024 || i == abbreviations.Length - 1) {
                        speedText = (((int)(speed * 100)) / 100.0) + " " + abbreviations[i];
                        break;
                    }
                }

                this.dayzLogParserForm.blissHiveDownloadProgressBar.Minimum = 0;
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Maximum = (int)length;
                // Just wait if the current is a bit larger than length
                if (current > length)
                    current = length;
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Value = (int)current;

                this.dayzLogParserForm.SetStatusText(1, "DL: " + speedText);
            }
        }

        /// <summary>
        /// Called when the download for the blisshive.log has finished.
        /// </summary>
        public override void FinishedDownload(String filePath) {

            // Cleanup the status bar, progress bar etc
            this.dayzLogParserForm.CleanupDownload();

            this.dayzLogParserForm.blissHiveParseHandler = new BlissHiveParseHandler(this.dayzLogParserForm);
            this.dayzLogParserForm.blissHiveParseHandler.StartLogParse(filePath);
        }

        /// <summary>
        /// Called when the download has failed.
        /// </summary>
        /// <param name="code">Fault code</param>
        /// <param name="reason">Reason for failing.</param>
        public override void FailedDownload(int code, String reason) {
            if (code == 2) {
                MessageBox.Show("FTP settings are incorrect. '" + reason + "'");
                this.CancelDownload();
            }
        }

        public override void CancelDownload() {
            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { this.CancelDownload(); }));

            } else {
                this.Cleanup();
            }
        }

        public override void Cleanup() {
            this.dayzLogParserForm.CleanupDownload();
        }
    }
}

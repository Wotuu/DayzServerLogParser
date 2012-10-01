using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DayzLogParser.FTP;
using DayzLogParser.Log.BlissHive;
using DayzLogParser.Log;

namespace DayzLogParser.UI {
    public partial class DayzLogParserForm : Form {

        public DayzLogParserForm() {
            InitializeComponent();
            this.blisshiveLogFetchTimeDropdown.SelectedIndex = 0;
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OptionsMenuItem_Click(object sender, EventArgs e) {
            OptionsForm of = new OptionsForm();
            of.ShowDialog(this);
        }

        private void BlisshiveDownloadLogBtn_Click(object sender, EventArgs e) {
            if (this.blisshiveDownloadLogBtn.Text == "Start") {
                FTPController.GetInstance().blissHiveDownloader = new LogFileDownloader(LogFileDownloader.LogFile.BlissHive);
                FTPController.GetInstance().blissHiveDownloader.progressUpdatedListeners += this.BlisshiveDownloadProgress;
                FTPController.GetInstance().blissHiveDownloader.downloadStoppedListeners += this.BlisshiveDownloadStopped;
                FTPController.GetInstance().blissHiveDownloader.downloadFinishedListeners += this.BlisshiveDownloadFinished;

                toolStripDownloadStatus.Text = "Downloading blisshive.log..";
                this.blisshiveDownloadLogBtn.Text = "Stop";
            } else if (this.blisshiveDownloadLogBtn.Text == "Stop") {
                FTPController.GetInstance().blissHiveDownloader.StopDownload();
            }
        }

        /// <summary>
        /// Called when the download for the blisshive.log has stopped by the user (or ftp client).
        /// </summary>
        private void BlisshiveDownloadStopped() {
            this.BlisshiveInvokeClearProgressBar();
        }

        /// <summary>
        /// Called when the download for the blisshive.log has finished.
        /// </summary>
        private void BlisshiveDownloadFinished(String filePath) {
            this.BlisshiveInvokeClearProgressBar();

            this.BlisshiveInvokeStartLogParse(filePath);

            this.BlisshiveInvokeClearProgressBar();
        }


        /// <summary>
        /// Clears the progressbar, and invokes if needed.
        /// </summary>
        private void BlisshiveInvokeClearProgressBar() {
            if (this.blisshiveDownloadProgressBar.InvokeRequired) {
                this.Invoke(
                   new Action(
                         delegate() {
                             BlisshiveClearProgressBar();
                         }
                   ));
            } else {
                BlisshiveClearProgressBar();
            }
        }

        private void BlisshiveInvokeStartLogParse(String filePath) {
            BlissHiveLogContainer blissHiveLogParser = new BlissHiveLogContainer();

            if (this.blisshiveDownloadProgressBar.InvokeRequired) {
                this.Invoke(
                   new Action(
                         delegate() {
                             this.toolStripDownloadStatus.Text = "Parsing log file..";
                             this.toolStripDownloadSpeed.Text = "(This may take a while)";

                             this.blisshiveDownloadProgressBar.Minimum = 0;
                             this.blisshiveDownloadProgressBar.Maximum = blissHiveLogParser.GetLogCount(filePath);
                         }
                   ));
            } else {
                this.toolStripDownloadStatus.Text = "Parsing log file..";
                this.toolStripDownloadSpeed.Text = "(This may take a while)";

                this.blisshiveDownloadProgressBar.Minimum = 0;
                this.blisshiveDownloadProgressBar.Maximum = blissHiveLogParser.GetLogCount(filePath);
            }

            blissHiveLogParser.LoadLog(filePath);
            blissHiveLogParser.ParseLog();
            LogController.GetInstance().blissHiveLogParser = blissHiveLogParser;
        }

        /// <summary>
        /// Clears the progress bar.
        /// </summary>
        private void BlisshiveClearProgressBar() {
            this.blisshiveDownloadProgressBar.Minimum = 0;
            this.blisshiveDownloadProgressBar.Maximum = 1;
            this.blisshiveDownloadProgressBar.Value = 0;
            toolStripDownloadStatus.Text = "";
            toolStripDownloadSpeed.Text = "";
        }

        /// <summary>
        /// Called when the blisshive download progress should be updated.
        /// </summary>
        /// <param name="current">The current progress.</param>
        /// <param name="length">The maximum progress</param>
        private void BlisshiveDownloadProgress(long current, long length, double speed) {
            if (this.blisshiveDownloadProgressBar.InvokeRequired) {
                this.Invoke(
                   new Action(
                         delegate() {
                             BlisshiveUpdateDownloadProgress(current, length, speed);
                         }
                   ));
            } else {
                BlisshiveUpdateDownloadProgress(current, length, speed);
            }
        }

        private void BlisshiveUpdateDownloadProgress(long current, long length, double speed) {
            this.blisshiveDownloadProgressBar.Minimum = 0;
            this.blisshiveDownloadProgressBar.Maximum = (int)length;
            // Just wait if the current is a bit larger than length
            if (current > length)
                current = length;
            this.blisshiveDownloadProgressBar.Value = (int)current;

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

            this.toolStripDownloadSpeed.Text = "DL: " + speedText;
        }

        /// <summary>
        /// Called when the user types something in the textfield.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlisshiveFetchMinutesTF_TextChanged(object sender, EventArgs e) {
            int value = 0;
            if (this.blisshiveFetchMinutesTF.Text.Length > 0 &&
                Int32.TryParse(this.blisshiveFetchMinutesTF.Text, out value) &&
                value > 0) {
                this.blisshiveDownloadLogBtn.Enabled = true;
            } else this.blisshiveDownloadLogBtn.Enabled = false;
        }
    }
}

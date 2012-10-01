using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DayzLogParser.FTP;

namespace DayzLogParser.UI {
    public partial class DayzLogParserForm : Form {

        public DayzLogParserForm() {
            InitializeComponent();
            this.blisshiveLogFetchTimeDropdown.SelectedIndex = 0;
        }

        private void exitMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void optionsMenuItem_Click(object sender, EventArgs e) {
            OptionsForm of = new OptionsForm();
            of.ShowDialog(this);
        }

        private void blisshiveDownloadLogBtn_Click(object sender, EventArgs e) {
            if (this.blisshiveDownloadLogBtn.Text == "Start") {
                FTPController.GetInstance().blissHiveDownloader = new LogFileDownloader(LogFileDownloader.LogFile.BlissHive);
                FTPController.GetInstance().blissHiveDownloader.progressUpdatedListeners += this.blisshiveDownloadProgress;
                this.blisshiveDownloadLogBtn.Text = "Stop";
            } else if (this.blisshiveDownloadLogBtn.Text == "Stop") {
                FTPController.GetInstance().blissHiveDownloader.StopDownload();
            }
        }

        private void blisshiveDownloadProgress(long current, long length) {
            if (this.blisshiveDownloadProgressBar.InvokeRequired) {
                this.Invoke(
                   new Action(
                         delegate() {
                             this.blisshiveDownloadProgressBar.Minimum = 0;
                             this.blisshiveDownloadProgressBar.Maximum = (int)length;
                             // Just wait if the current is a bit larger than length
                             if (current > length)
                                 current = length;
                             this.blisshiveDownloadProgressBar.Value = (int)current;
                         }
                   ));
            } else {
                this.blisshiveDownloadProgressBar.Minimum = 0;
                this.blisshiveDownloadProgressBar.Maximum = (int)length;
                this.blisshiveDownloadProgressBar.Value = (int)current;
            }
        }

        private void blisshiveFetchMinutesTF_TextChanged(object sender, EventArgs e) {
            int value = 0;
            if (this.blisshiveFetchMinutesTF.Text.Length > 0 &&
                Int32.TryParse(this.blisshiveFetchMinutesTF.Text, out value) &&
                value > 0) {
                this.blisshiveDownloadLogBtn.Enabled = true;
            } else this.blisshiveDownloadLogBtn.Enabled = false;
        }
    }
}

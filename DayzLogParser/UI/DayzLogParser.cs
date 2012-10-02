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
using DayzLogParser.Settings;
using DayzLogParser.Settings.BlissHive;
using System.Net;
using DayzLogParser.UI.BlissHive;

namespace DayzLogParser.UI {
    public partial class DayzLogParserForm : Form {

        public BlissHiveDownloadHandler blisshiveDownloadHandler { get; private set; }

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

                if (this.blisshiveDownloadHandler != null) {
                    this.blisshiveDownloadHandler.CancelDownload();
                    this.blisshiveDownloadHandler.Cleanup();
                }

                this.blisshiveDownloadHandler = new BlissHiveDownloadHandler(this);
                this.blisshiveDownloadHandler.StartDownload();

            } else if (this.blisshiveDownloadLogBtn.Text == "Stop") {

                FTPController.GetInstance().blissHiveDownloader.StopDownload();
                this.blisshiveDownloadHandler.CancelDownload();
            }
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

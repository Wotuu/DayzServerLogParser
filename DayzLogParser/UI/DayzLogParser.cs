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
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.UI {
    public partial class DayzLogParserForm : Form {

        public BlissHiveDownloadHandler blissHiveDownloadHandler { get; set; }
        public BlissHiveParseHandler blissHiveParseHandler { get; set; }
        public BlissHivePlayerTreeHandler blissHivePlayerTreeHandler { get; set; }

        public DayzLogParserForm() {
            InitializeComponent();
            this.blissHiveLogFetchTimeDropdown.SelectedIndex = 0;
            this.blissHivePlayerTreeHandler = new BlissHivePlayerTreeHandler(this);
            
            // Expands the "survivor" node
            foreach( TreeNode node in this.blissHivePlayerTree.Nodes ){
                node.Expand();
            }

            // Disable all tabs untill someone loaded something.
            /*
            foreach (TabPage tab in this.blissHivePlayerDataTabControl.TabPages) {
                tab.Enabled = false;
            }
            this.blissHivePlayerDataTabControl.Enabled = false;*/
        }

        private void ExitMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OptionsMenuItem_Click(object sender, EventArgs e) {
            OptionsForm of = new OptionsForm();
            of.ShowDialog(this);
        }

        private void BlisshiveDownloadLogBtn_Click(object sender, EventArgs e) {
            if (this.blissHiveDownloadLogBtn.Text == "Start") {

                if (this.blissHiveDownloadHandler != null) {
                    this.blissHiveDownloadHandler.CancelDownload();
                    this.blissHiveDownloadHandler.Cleanup();
                }

                this.blissHiveDownloadHandler = new BlissHiveDownloadHandler(this);
                this.blissHiveDownloadHandler.StartDownload();

            } else if (this.blissHiveDownloadLogBtn.Text == "Stop") {

                FTPController.GetInstance().blissHiveDownloader.StopDownload();
                this.blissHiveDownloadHandler.CancelDownload();
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
                this.blissHiveDownloadLogBtn.Enabled = true;
            } else this.blissHiveDownloadLogBtn.Enabled = false;
        }

        /// <summary>
        /// Cleans up a download
        /// </summary>
        public void CleanupDownload() {
            if (this.blissHiveDownloadProgressBar.InvokeRequired) {
                this.BeginInvoke(new MethodInvoker(delegate() { this.CleanupDownload(); }));

            } else {
                if (blissHiveDownloadHandler != null)
                    this.blissHiveDownloadHandler.ClearProgressBar();
                this.blissHiveDownloadLogBtn.Text = "Start";

                this.SetStatusText(0, "");
                this.SetStatusText(1, "");
            }
        }

        /// <summary>
        /// Cleans up a parse.
        /// </summary>
        public void CleanupParse() {
            if (this.blissHiveDownloadProgressBar.InvokeRequired) {
                this.BeginInvoke(new MethodInvoker(delegate() { this.CleanupParse(); }));

            } else {
                if (this.blissHiveParseHandler != null)
                    this.blissHiveParseHandler.ClearProgressBar();
                this.blissHiveDownloadLogBtn.Enabled = true;
                this.blissHiveDownloadLogBtn.Text = "Start";

                foreach (MenuItem item in this.fileMenuItem.MenuItems) {
                    if ((String)item.Tag == "openFile") {
                        item.Enabled = true;
                        // Don't break
                        // break;
                    }
                }
                this.SetStatusText(0, "");
                this.SetStatusText(1, "");
            }
        }

        /// <summary>
        /// Sets the status text of the log parser
        /// </summary>
        /// <param name="number">The text number to set</param>
        /// <param name="texts">The texts to set</param>
        public void SetStatusText(int number, String text) {
            if (this.blissHiveDownloadProgressBar.InvokeRequired) {
                this.BeginInvoke(new MethodInvoker(delegate() { this.SetStatusText(number, text); }));

            } else {
                if (number == 0)
                    this.toolStripStatusText1.Text = text;
                else if (number == 1)
                    this.toolStripStatusText2.Text = text;
            }
        }

        private void openBlissHiveMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "log";
            openFileDialog.Filter = "blisshive.log|*.log";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                this.blissHiveParseHandler = new BlissHiveParseHandler(this);
                this.blissHiveParseHandler.StartLogParse(openFileDialog.FileName);
            }
        }
    }
}

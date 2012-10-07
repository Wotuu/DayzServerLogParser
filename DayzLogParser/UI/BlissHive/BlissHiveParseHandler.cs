using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive;
using DayzLogParser.Log;
using System.Windows.Forms;
using System.ComponentModel;

namespace DayzLogParser.UI.BlissHive {
    public class BlissHiveParseHandler : LogParseHandler {

        public BlissHiveParseHandler(DayzLogParserForm dayzLogParser) :
            base(dayzLogParser) {

        }



        /// <summary>
        /// Starts the log parse, with given filePath, and invokes if needed.
        /// </summary>
        /// <param name="filePath">The filepath of the file</param>
        public void StartLogParse(String filePath) {

            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { StartLogParse(filePath); }));
            } else {
                foreach (MenuItem item in this.dayzLogParserForm.fileMenuItem.MenuItems) {
                    if ((String)item.Tag == "openFile") {
                        item.Enabled = false;
                        // Don't break
                        // break;
                    }
                }
                this.dayzLogParserForm.blissHiveDownloadLogBtn.Text = "Parsing..";
                this.dayzLogParserForm.blissHiveDownloadLogBtn.Enabled = false;

                BlissHiveLogContainer blissHiveLogContainer = new BlissHiveLogContainer();

                int maximum = blissHiveLogContainer.GetLogCount(filePath);
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Minimum = 0;
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Maximum = maximum;


                LogController.GetInstance().blissHiveLogContainer = blissHiveLogContainer;

                // Start a background worker to do calculating stuff outside of the UI thread
                BackgroundWorker bw = new BackgroundWorker();
                bw.RunWorkerAsync(filePath);
                bw.DoWork += new DoWorkEventHandler(bw_DoWork);

                bw.WorkerSupportsCancellation = false;
                bw.WorkerReportsProgress = false;
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e) {
            // Start parsing some more
            this.dayzLogParserForm.blissHiveParseHandler =
                new BlissHiveParseHandler(this.dayzLogParserForm);

            this.dayzLogParserForm.SetStatusText(0, "Parsing log file..");
            this.dayzLogParserForm.SetStatusText(1, "this may take a while");
            LogController.GetInstance().blissHiveLogContainer.
                onParseProgressListeners += this.OnParseProgress;
            LogController.GetInstance().blissHiveLogContainer.LoadLog((String)e.Argument);

            this.dayzLogParserForm.SetStatusText(0, "Analysing parsed data..");
            LogController.GetInstance().blissHiveLogContainer.ParseLog();

            // Loads in survivors
            this.dayzLogParserForm.blissHivePlayerTreeHandler.LoadSurvivors();

            // Cleanup the status bar, progress bar etc
            this.dayzLogParserForm.CleanupParse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="current"></param>
        /// <param name="max"></param>
        private void OnParseProgress(int current, int max) {
            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { this.OnParseProgress(current, max); }));
            } else {
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Maximum = max;
                this.dayzLogParserForm.blissHiveDownloadProgressBar.Value = current;
                // Console.WriteLine(current + "/" + max);
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
    }
}

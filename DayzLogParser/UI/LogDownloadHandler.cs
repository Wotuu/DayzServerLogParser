using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.UI {
    public abstract class LogDownloadHandler {
        public DayzLogParserForm dayzLogParserForm { get; set; }

        public LogDownloadHandler(DayzLogParserForm dayzLogParserForm) {
            this.dayzLogParserForm = dayzLogParserForm;
        }

        public abstract void StartDownload();
        public abstract void CancelDownload();
        public abstract void OnDownloadProgress(long current, long length, double speed);
        public abstract void FinishedDownload(String filePath);
        public abstract void FailedDownload(int code, String reason);
        public abstract void Cleanup();

    }
}

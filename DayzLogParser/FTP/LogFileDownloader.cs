using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace DayzLogParser.FTP {
    public class LogFileDownloader : ASyncFTPDownloader {
        public LogFile logFile { get; private set; }

        public enum LogFile {
            BlissHive = 0
        };
        
        public LogFileDownloader(LogFile logfile) :
            base("ftp://94.242.227.182:8821/", new NetworkCredential("Wotuu", "WotuuACP")) {

                this.logFile = logfile;

                String logFileName = "";
                switch (this.logFile) {
                    case 0:
                        logFileName = "blisshive.log";
                        break;
                    default:
                        throw new Exception("Invalid Logfile.");
                }
                this.StartDownload("94.242.227.182_2362/" + logFileName);
        }
    }
}

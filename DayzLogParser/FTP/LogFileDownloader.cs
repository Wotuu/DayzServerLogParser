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
        
        public LogFileDownloader(String IP, String Port, NetworkCredential credentials, String rootFolder, LogFile logfile) :
            base("ftp://" + IP + ":" + Port + "/", credentials) {

                this.logFile = logfile;

                String logFileName = "";
                switch (this.logFile) {
                    case 0:
                        logFileName = "blisshive.log";
                        break;
                    default:
                        throw new Exception("Invalid Logfile.");
                }
                this.StartDownload(rootFolder + "/" + logFileName);
        }
    }
}

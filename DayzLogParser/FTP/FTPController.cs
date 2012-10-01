using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.FTP {
    public class FTPController {

        private static FTPController instance { get; set; }
        public LogFileDownloader blissHiveDownloader { get; set; }

        private FTPController() {

        }

        public static FTPController GetInstance() {
            if (instance == null) instance = new FTPController();
            return instance;
        }

    }
}

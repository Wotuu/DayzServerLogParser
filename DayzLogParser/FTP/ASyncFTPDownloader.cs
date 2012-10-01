using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;

namespace DayzLogParser.FTP {
    public class ASyncFTPDownloader : FTPDownloader {


        public ASyncFTPDownloader(String ip, NetworkCredential credentials)
            : base(ip, credentials) {

        }

        private String filepath { get; set; }
        public override void StartDownload(String filepath) {
            this.filepath = filepath;
            new Thread(new ThreadStart(this.StartDownload)).Start();
        }

        private void StartDownload() {
            base.StartDownload(this.filepath);
        }
    }
}

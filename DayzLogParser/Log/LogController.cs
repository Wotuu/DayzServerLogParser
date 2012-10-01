using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive;

namespace DayzLogParser.Log {
    public class LogController {

        private static LogController instance { get; set; }

        public BlissHiveLogContainer blissHiveLogParser { get; set; }

        public static LogController GetInstance() {
            if (LogController.instance == null) LogController.instance = new LogController();
            return instance;
        }
    }
}

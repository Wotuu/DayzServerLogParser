using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log {
    public abstract class LogSurvivor {
        public String username { get; protected set; }
        public LinkedList<LogEntry> logEntries { get; protected set; }

        public LogSurvivor(String username) {
            this.username = username;
            this.logEntries = new LinkedList<LogEntry>();
        }
    }
}

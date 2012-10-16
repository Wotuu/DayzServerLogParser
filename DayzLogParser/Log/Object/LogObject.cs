using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.Object {
    public abstract class LogObject {
        public LinkedList<LogEntry> logEntries { get; protected set; }

        public LogObject() {
            this.logEntries = new LinkedList<LogEntry>();
        }
    }
}

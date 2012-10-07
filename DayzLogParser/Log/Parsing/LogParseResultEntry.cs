using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.Parsing {
    public abstract class LogParseResultEntry {

        public LogEntry logEntry;

        public LogParseResultEntry(LogEntry logEntry) {
            this.logEntry = logEntry;
        }
    }
}

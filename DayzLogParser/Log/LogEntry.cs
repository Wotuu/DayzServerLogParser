using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log {
    public abstract class LogEntry {
        public String original { get; protected set; }

        public String timestamp { get; protected set; }
        public String logType { get; protected set; }
        public String map { get; protected set; }
        public String commandType { get; protected set; }

        public String message { get; protected set; }
        public String functionName { get; protected set; }
        public String parameters { get; protected set; }

        public LogEntry(String entry) {
            this.original = entry;
            this.ParseOriginal();
        }

        public abstract void ParseOriginal();
    }
}

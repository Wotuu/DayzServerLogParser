using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Object;

namespace DayzLogParser.Log.BlissHive.Parsing.Object {
    public class BlissHiveObjectLogParseResultEntry : LogParseResultEntry {
        public BlissHiveLogObject logObject { get; private set; }

        public BlissHiveObjectLogParseResultEntry(LogEntry entry, BlissHiveLogObject logObject)
            : base(entry) {
                this.logObject = logObject;
                // this.logObject.lastSignOfActivity = entry.timestampUnix;
        }
    }
}

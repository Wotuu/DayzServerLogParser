using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Parsing {
    public class BlissHiveSurvivorLogParseResultEntry : LogParseResultEntry {
        public BlissHiveLogSurvivor survivor { get; private set; }

        public BlissHiveSurvivorLogParseResultEntry(LogEntry entry, BlissHiveLogSurvivor survivor)
            : base(entry) {
            this.survivor = survivor;
            this.survivor.lastSignOfActivity = entry.timestampUnix;
        }
    }
}

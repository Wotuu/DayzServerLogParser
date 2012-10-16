using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Parsing.Object.Inventory {
    public class BlissHiveObjectInventoryLogParseResultEntry : LogParseResultEntry {
        public BlissHiveObjectInventoryLogParseResultEntry(LogEntry entry)
            : base(entry) {

        }
    }
}

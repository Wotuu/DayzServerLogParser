using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Parsing.Inventory {
    public class BlissHiveInventoryLogParseResultEntry : LogParseResultEntry {
        public BlissHiveInventoryLogParseResultEntry(LogEntry entry)
            : base(entry) {

        }
    }
}

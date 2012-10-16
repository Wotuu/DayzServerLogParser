using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Inventory;

namespace DayzLogParser.Log.BlissHive.Parsing.Survivor.Activity {
    public class BlissHiveActivityLogParseResultEntry : LogParseResultEntry {

        public LinkedList<BlissHiveLogActivityItem> changedItems { get; set; }

        public BlissHiveActivityLogParseResultEntry(LogEntry entry)
            : base(entry) {

        }
    }
}

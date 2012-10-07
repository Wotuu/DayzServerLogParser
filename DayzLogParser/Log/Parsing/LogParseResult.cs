using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.Parsing {
    public class LogParseResult {

        public LinkedList<LogParseResultEntry> result { get; set; }

        public LogParseResult(LinkedList<LogParseResultEntry> result) {
            this.result = result;
        }
    }
}

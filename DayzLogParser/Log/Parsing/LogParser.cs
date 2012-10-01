using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.Parsing {
    public abstract class LogParser {
        public LogContainer container { get; private set; }

        public LogParser() {

        }
    }
}

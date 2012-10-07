using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;

namespace DayzLogParser.Log.Survivor {
    public abstract class LogSurvivorContainer {

        public LinkedList<LogSurvivor> survivors { get; private set; }

        public LogSurvivorContainer() {
            this.survivors = new LinkedList<LogSurvivor>();
        }
    }
}

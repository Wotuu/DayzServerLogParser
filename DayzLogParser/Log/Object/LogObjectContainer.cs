using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.Object {
    public abstract class LogObjectContainer {

        public LinkedList<LogObject> logObjects { get; private set; }

        public LogObjectContainer() {
            this.logObjects = new LinkedList<LogObject>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive {
    public class BlissHiveLogContainer : LogContainer {


        public override LogEntry CreateLog(string original) {
            return new BlissHiveLogEntry(original);
        }

        public override void ParseLog() {

        }
    }
}

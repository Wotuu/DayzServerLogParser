using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive {
    public class BlissHiveLogEntry : LogEntry {

        public BlissHiveLogEntry(String original)
            : base(original) {

        }

        public override void ParseOriginal() {
            String[] split = this.original.Split(' ');

            this.timestamp = split[0] + " " + split[1];
            this.logType = split[2];

            if (this.logType == "INFO") {
                this.map = split[5].Split('.')[1];
                this.commandType = split[7].Replace(":", "");

                for (int i = 9; i < split.Length; i++) {
                    this.message += split[i] + " ";
                }
                this.functionName = this.message.Split('(')[0];
                this.parameters = this.message.Replace(this.functionName, "").Trim(new char[] { '(', ')' });
            } else if (this.logType == "ERROR") {
                for (int i = 3; i < split.Length; i++) {
                    this.message += split[i] + " ";
                }
            }
        }
    }
}

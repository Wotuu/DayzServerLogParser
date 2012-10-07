using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive {
    public class BlissHiveLogEntry : LogEntry {
        private IFormatProvider usCulture = new System.Globalization.CultureInfo("en-US", true);

        public BlissHiveLogEntry(String original)
            : base(original) {

        }

        public override void ParseOriginal() {
            String[] split = this.original.Split(' ');

            this.timestamp = split[0] + " " + split[1];
            this.timestampUnix = new TimeSpan(DateTime.Parse(this.timestamp, this.usCulture, System.Globalization.DateTimeStyles.AssumeLocal).Ticks).TotalMilliseconds;
            this.logType = split[2];

            if (this.logType == "INFO") {
                this.map = split[5].Split('.')[1];
                this.commandType = split[7].Replace(":", "");

                for (int i = 9; i < split.Length; i++) {
                    this.message += split[i] + " ";
                }
                this.functionName = this.message.Split('(')[0];
                this.parameters = this.message.Replace(this.functionName, "")
                                    .Trim()
                                    .Trim('(')
                                    .Trim(')')
                                    .Split(new String[1]{", "}, StringSplitOptions.None);

                for (int i = 0; i < this.parameters.Length; i++) {
                    this.parameters[i] = this.parameters[i].Trim()
                                        .Trim('(')
                                        .Trim(')')
                                        .Trim('\'')
                                        .Trim('"');
                }
            } else if (this.logType == "ERROR") {
                for (int i = 3; i < split.Length; i++) {
                    this.message += split[i] + " ";
                }
            }
        }
    }
}

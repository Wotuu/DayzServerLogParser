using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Web.InsertData {
    public class InsertDataPost : HttpPostRequester {

        public InsertDataPost()
            : base("http://www.clearbits.nl/r/dayz/insert_data.php", "") {

        }

        public void ParseData(BlissHiveLogContainer container) {
            int count = 0;
            StringBuilder b = new StringBuilder();
            foreach (BlissHiveLogSurvivor survivor in container.survivorContainer.survivors) {
                b.Append("survivor_" + count + "[]").Append("=").Append(survivor.username ?? "").Append("&");
                b.Append("survivor_" + count + "[]").Append("=").Append(survivor.survivorUpdateID ?? "").Append("&");
                foreach (String str in survivor.locations) {
                    b.Append("survivor_" + count + "_locations[]").Append("=").Append(str).Append("&");
                }
                count++;
            }
            this.data = b.ToString();
            // this.data = String.Join("&", result.ToArray<String>());
        }
    }
}

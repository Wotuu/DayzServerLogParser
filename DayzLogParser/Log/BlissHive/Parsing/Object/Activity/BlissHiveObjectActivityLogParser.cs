using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Inventory;
using DayzLogParser.Log.BlissHive.Object;

namespace DayzLogParser.Log.BlissHive.Parsing.Object.Activity {
    public class BlissHiveObjectActivityLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveObjectActivityLogParser(BlissHiveLogContainer container)
            : base(container) {

        }

        public override LogParseResult Parse() {
            LinkedList<LogParseResultEntry> result = new LinkedList<LogParseResultEntry>();

            BlissHiveLogContainer blissHiveLogContainer = (BlissHiveLogContainer)this.container;

            foreach( BlissHiveLogObject logObject in blissHiveLogContainer.logObjectContainer.logObjects ){
                for( int i = 0; i < logObject.inventories.Count - 1; i++ ){
                    BlissHiveLogInventory inv = logObject.inventories.ElementAt(i);
                    BlissHiveLogInventory nextInv = logObject.inventories.ElementAt(i + 1);

                    LinkedList<BlissHiveLogActivityItem> changedItems =
                        BlissHiveLogInventory.GetItemDifference(inv, nextInv);

                    changedItems = BlissHiveLogInventory.AddObject(logObject, changedItems);

                    BlissHiveObjectActivityLogParseResultEntry change =
                        new BlissHiveObjectActivityLogParseResultEntry(nextInv.originalLogEntry);
                    change.changedItems = changedItems;

                    result.AddLast(change);
                }
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
        }



        public override int GetProgressMaxLength() {
            return this.container.logs.Length;
        }
    }
}

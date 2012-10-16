using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Object;
using System.Globalization;

namespace DayzLogParser.Log.BlissHive.Parsing.Object {
    public class BlissHiveObjectLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveObjectLogParser(BlissHiveLogContainer container)
            : base(container) {

        }

        public override LogParseResult Parse() {
            LinkedList<LogParseResultEntry> result =
                new LinkedList<LogParseResultEntry>();

            int count = 0;

            foreach (BlissHiveLogEntry entry in container.logs) {
                BlissHiveObjectLogParseResultEntry resultEntry = null;
                Boolean addEntryToResult = false;
                // Are we checking the stats now?
                if (entry.functionName == "proc_updateObjectPosition") {
                    resultEntry = this.HandleFoundObjectUpdateID(result, entry, entry.parameters[0], out addEntryToResult);
                    // Console.WriteLine("Object update position -> " + resultEntry.logObject.objectUpdateID);
                    String[] location = entry.parameters[1]
                                    .Replace("[", "")
                                    .Replace("]", "")
                                    .Split(',');
                    location = new String[3] { location[1], location[2], location[3] };

                    resultEntry.logObject.locations.AddLast(location);
                    resultEntry.logObject.logEntries.AddLast(entry);

                } else if (entry.functionName == "proc_updateObjectHealth") {
                    
                    resultEntry = this.HandleFoundObjectUpdateID(result, entry, entry.parameters[0], out addEntryToResult);

                    String[] health = entry.parameters[1]
                                    .Replace("[", "")
                                    .Replace("]", "")
                                    .Replace("\"", "")
                                    .Split(',');
                    // If there's at least one health update
                    if (health.Length > 1) {
                        for( int i = 0; i < health.Length; i += 2 ){
                            resultEntry.logObject.SetHealth(health[i], 
                                Double.Parse(health[i + 1], NumberStyles.Float, CultureInfo.InvariantCulture));
                        }
                    }

                    resultEntry.logObject.logEntries.AddLast(entry);
                } else if (entry.functionName == "proc_updateObjectInventory") {
                    resultEntry = this.HandleFoundObjectUpdateID(result, entry, entry.parameters[0], out addEntryToResult);

                    resultEntry.logObject.logEntries.AddLast(entry);
                }

                if (addEntryToResult)
                    result.AddLast(resultEntry);

                this.onParseProgressListeners(count, this.container.logs.Length);
                count++;
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
        }

        #region Helper functions
        /// <summary>
        /// If a object Update ID was found, we need to check if that object already exists.
        /// If it doesn't, a new result is created, and returned. Otherwise, the existing entry
        /// is returned.
        /// </summary>
        /// <param name="result">The result up till now</param>
        /// <param name="entry">The entry that you found the object updated ID in</param>
        /// <param name="objectUpdateID">The object update id to search for</param>
        /// <returns></returns>
        private BlissHiveObjectLogParseResultEntry HandleFoundObjectUpdateID(
                LinkedList<LogParseResultEntry> result, 
                BlissHiveLogEntry entry, 
                String objectUpdateID,
                out Boolean addEntryToResult) {
            BlissHiveObjectLogParseResultEntry existingObject = null;
            // Check if the object already exists
            if ((existingObject = this.GetObject(result, objectUpdateID)) != null) {
                // The object exists!
                addEntryToResult = false;
                return existingObject;
            } else {
                // Didn't exist, return a new result
                addEntryToResult = true;
                return new BlissHiveObjectLogParseResultEntry(entry, new BlissHiveLogObject(objectUpdateID));
            }
        }

        /// <summary>
        /// Checks if a given name already exists in the result set.
        /// </summary>
        /// <param name="result">The result set to search.</param>
        /// <param name="survivorName">The survivor name to search for.</param>
        /// <returns>Yes or no.</returns>
        private Boolean ContainsObject(LinkedList<LogParseResultEntry> result, String objectUpdateID) {
            return GetObject(result, objectUpdateID) != null;
        }

        /// <summary>
        /// Gets a given object, based on its objectUpdateID
        /// </summary>
        /// <param name="result"></param>
        /// <param name="objectUpdateID"></param>
        /// <returns></returns>
        private BlissHiveObjectLogParseResultEntry GetObject(LinkedList<LogParseResultEntry> result, String objectUpdateID) {
            foreach (BlissHiveObjectLogParseResultEntry entry in result) {
                if (entry.logObject.objectUpdateID == objectUpdateID)
                    return entry;
            }
            return null;
        }
#endregion

        public override int GetProgressMaxLength() {
            return this.container.logs.Length;
        }
    }
}

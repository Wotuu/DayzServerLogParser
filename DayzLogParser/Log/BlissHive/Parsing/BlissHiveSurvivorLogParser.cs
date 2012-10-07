using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Parsing {
    public class BlissHiveSurvivorLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveSurvivorLogParser(BlissHiveLogContainer container)
            : base(container) {

        }

        public override LogParseResult Parse() {
            LinkedList<LogParseResultEntry> result =
                new LinkedList<LogParseResultEntry>();

            String currentUsername = "";
            int count = 0;

            foreach (BlissHiveLogEntry entry in container.logs) {
                // Are we checking the stats now?
                if (entry.functionName == "proc_getSurvivorStats" ) {
                    // Yes, is the user name already set? (Hope so!)
                    if (currentUsername != "") {
                        // Valid, normal result
                        if (this.ContainsSurvivor(result, currentUsername)) {
                            // Yay, it contained it!
                            BlissHiveSurvivorLogParseResultEntry resultEntry = this.GetSurvivor(result, currentUsername);
                            resultEntry.survivor.survivorUpdateID = entry.parameters[0];
                            resultEntry.survivor.logEntries.AddLast(entry);
                        } else {
                            // It wasn't there .. can't do much with just an update ID
                        }
                        // Reset the username
                        currentUsername = "";
                    } else {
                        // Shit .. we just missed someone's login name, best to drop it
                    }
                } else if (entry.functionName == "proc_loginSurvivor") {
                    // Did we already have a username set?
                    if (currentUsername != "") {
                        // It's already set, which means that the next updateSurvivor function call
                        // will be either of this guy, or the previous guy. Can't tell, gotta skip both
                        currentUsername = "";
                    } else {
                        currentUsername = entry.parameters[1];
                        if (!this.ContainsSurvivor(result, currentUsername)) {
                            // New player joined that wasn't in the log yet!
                            BlissHiveLogSurvivor survivor = new BlissHiveLogSurvivor(currentUsername, entry.parameters[0]);
                            BlissHiveSurvivorLogParseResultEntry resultEntry =
                                new BlissHiveSurvivorLogParseResultEntry(entry, survivor);
                            result.AddLast(resultEntry);
                            survivor.logEntries.AddLast(entry);
                        } else {
                            // New player joined that was already in the logs
                            foreach (BlissHiveSurvivorLogParseResultEntry resultEntry in result) {
                                if (resultEntry.survivor.survivorID == entry.parameters[0]) {
                                    resultEntry.survivor.online = true;
                                    resultEntry.survivor.logEntries.AddLast(entry);
                                    break;
                                }
                            }
                        }
                    }
                } else if (entry.functionName == "proc_logLogout") {
                    foreach (BlissHiveSurvivorLogParseResultEntry resultEntry in result) {
                        if (resultEntry.survivor.survivorID == entry.parameters[0]) {
                            resultEntry.survivor.online = false;
                            resultEntry.survivor.logEntries.AddLast(entry);
                            break;
                        }
                    }
                } else if (entry.functionName == "proc_updateSurvivor") {
                    foreach (BlissHiveSurvivorLogParseResultEntry resultEntry in result) {
                        if (resultEntry.survivor.survivorUpdateID == entry.parameters[0]) {
                            resultEntry.survivor.lastSignOfActivity = entry.timestampUnix;
                            resultEntry.survivor.logEntries.AddLast(entry);
                            break;
                        }
                    }
                } else if (entry.functionName == "proc_killSurvivor") {
                    foreach (BlissHiveSurvivorLogParseResultEntry resultEntry in result) {
                        if (resultEntry.survivor.survivorUpdateID == entry.parameters[0]) {
                            resultEntry.survivor.logEntries.AddLast(entry);
                            break;
                        }
                    }
                }

                this.onParseProgressListeners(count, this.container.logs.Length);
                count++;
            }

            double lastTimestampUnix = this.container.logs[container.logs.Length - 1].timestampUnix;

            foreach (BlissHiveSurvivorLogParseResultEntry resultEntry in result) {
                // If we didn't hear from someone for at least OFFLINE_MS_LIMIT
                if (lastTimestampUnix - resultEntry.survivor.lastSignOfActivity > BlissHiveSurvivorLogParser.OFFLINE_MS_LIMIT) {
                    // He ain't online
                    resultEntry.survivor.online = false;
                }
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
        }

        /// <summary>
        /// Checks if a given name already exists in the result set.
        /// </summary>
        /// <param name="result">The result set to search.</param>
        /// <param name="survivorName">The survivor name to search for.</param>
        /// <returns>Yes or no.</returns>
        private Boolean ContainsSurvivor(LinkedList<LogParseResultEntry> result, String survivorName) {
            foreach (BlissHiveSurvivorLogParseResultEntry entry in result) {
                if (entry.survivor.username == survivorName)
                    return true;
            }
            return false;
        }

        private BlissHiveSurvivorLogParseResultEntry GetSurvivor(LinkedList<LogParseResultEntry> result, String survivorName) {
            foreach (BlissHiveSurvivorLogParseResultEntry entry in result) {
                if (entry.survivor.username == survivorName)
                    return entry;
            }
            return null;
        }

        public override int GetProgressMaxLength() {
            return this.container.logs.Length;
        }
    }
}

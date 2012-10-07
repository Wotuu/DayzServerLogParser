using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.Parsing {
    public abstract class LogParser {
        public LogContainer container { get; private set; }
        public OnLogParseProgress onParseProgressListeners { get; set; }

        public LogParser(LogContainer container) {
            this.container = container;
        }

        /// <summary>
        /// Parses whatever this parser is used for.
        /// </summary>
        /// <returns>The parse result, see LogParseResult for details.</returns>
        public abstract LogParseResult Parse();

        /// <summary>
        /// Gets the maximum parse length (for a progress bar).
        /// </summary>
        /// <returns>The maximum parse length.</returns>
        public abstract int GetProgressMaxLength();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.UI {
    public class LogParseHandler {

        public DayzLogParserForm dayzLogParserForm { get; set; }

        public LogParseHandler(DayzLogParserForm dayzLogParserForm) {
            this.dayzLogParserForm = dayzLogParserForm;
        }
    }
}

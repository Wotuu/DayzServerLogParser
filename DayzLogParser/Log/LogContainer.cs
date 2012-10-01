using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DayzLogParser.Log {
    public abstract class LogContainer {

        public LogEntry[] logs { get; private set; }

        public int GetLogCount(String filepath) {
            return File.ReadLines(filepath).Count();
        }

        public void LoadLog(String filepath) {
            int lineCount = this.GetLogCount(filepath);

            this.logs = new LogEntry[lineCount];
            // Read the file and display it line by line.
            String line = "";
            System.IO.StreamReader file =
               new System.IO.StreamReader(filepath);

            int count = 0;
            while ((line = file.ReadLine()) != null) {
                LogEntry entry = this.CreateLog(line);
                this.logs[count] = entry;
                count++;
            }

            file.Close();
        }

        public abstract LogEntry CreateLog(String original);
        public abstract void ParseLog();
    }
}

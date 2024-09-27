using System;
using System.Collections.Generic;
using System.Text;

namespace TianXiaTech.SystemInfoCollector.EventObject
{
    public class TinyEventLog
    {
        public string Source { get; private set; }

        public string Log { get; private set; }

        public List<TinyEventLogEntry> Entries { get; private set; }

        public string LogDisplayName { get; private set; }

        public string MachineName { get; private set; }

        public long MaximumKilobytes { get; private set; }
    }
}

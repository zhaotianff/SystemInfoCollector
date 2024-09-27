using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace TianXiaTech.SystemInfoCollector.EventObject
{
    public class TinyEventLogEntry
    {
        public string Category { get; private set; }

        public short CategoryNumber { get; private set; }

        public byte[] Data { get; private set; }

        public EventLogEntryType EntryType { get; private set; }

        public int Index { get; private set; }

        public long InstanceId { get; private set; }

        public string MachineName { get; private set; }

        public string Message { get; private set; }

        public string[] ReplacementStrings { get; private set; }

        public string Source { get; private set; }

        public DateTime TimeGenerated { get; private set; }

        public DateTime TimeWritten { get; private set; }

        public string UserName { get; private set; }
    }
}

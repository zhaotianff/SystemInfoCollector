using System;
using System.Collections.Generic;
using System.Text;

namespace TianXiaTech.SystemInfoCollector.WMIObject
{
    public class Win32Process
    {
       public string CreationClassName{get;set;}
       public string Caption{get;set;}
       public string CommandLine{get;set;}
       public string CreationDate{get;set;}
       public string CSCreationClassName{get;set;}
       public string CSName{get;set;}
       public string Description{get;set;}
       public string ExecutablePath{get;set;}
       public ushort ExecutionState{get;set;}
       public string Handle{get;set;}
       public uint HandleCount {get;set;}
       public string InstallDate{get;set;}
       public ulong KernelModeTime {get;set;}
       public uint MaximumWorkingSetSize{get;set;}
       public uint MinimumWorkingSetSize {get;set;}
       public string Name{get;set;}
       public string OSCreationClassName{get;set;}
       public string OSName{get;set;}
       public ulong OtherOperationCount {get;set;}
       public ulong OtherTransferCount {get;set;}
       public uint PageFaults {get;set;}
       public uint PageFileUsage {get;set;}
       public uint ParentProcessId {get;set;}
       public uint PeakPageFileUsage {get;set;}
       public ulong PeakVirtualSize{get;set;}
       public uint PeakWorkingSetSize{get;set;}
       public uint Priority{get;set;}
       public ulong PrivatePageCount{get;set;}
       public uint ProcessId{get;set;}
       public uint QuotaNonPagedPoolUsage{get;set;}
       public uint QuotaPagedPoolUsage{get;set;}
       public uint QuotaPeakNonPagedPoolUsage{get;set;}
       public uint QuotaPeakPagedPoolUsage{get;set;}
       public ulong ReadOperationCount{get;set;}
       public ulong ReadTransferCount{get;set;}
       public uint SessionId{get;set;}
       public string Status{get;set;}
       public string TerminationDate{get;set;}
       public uint ThreadCount{get;set;}
       public ulong UserModeTime{get;set;}
       public ulong VirtualSize{get;set;}
       public string WindowsVersion{get;set;}
       public ulong WorkingSetSize{get;set;}
       public ulong WriteOperationCount{get;set;}
       public ulong WriteTransferCount{get;set;}
    }
}

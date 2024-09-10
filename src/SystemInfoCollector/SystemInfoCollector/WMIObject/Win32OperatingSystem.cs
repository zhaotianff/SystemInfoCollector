﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace SystemInfoCollector.WMIObject
{
    public class Win32OperatingSystem
    {
        public string BootDevice { get; set; }
        public string BuildNumber { get; set; }
        public string BuildType { get; set; }
        public string Caption { get; set; }
        public string CodeSet { get; set; }
        public string CountryCode { get; set; }
        public string CreationClassName { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSDVersion { get; set; }
        public string CSName { get; set; }
        public System.UInt16 CurrentTimeZone { get; set; }
        public bool DataExecutionPrevention_Available { get; set; }
        public bool DataExecutionPrevention_32BitApplications { get; set; }
        public bool DataExecutionPrevention_Drivers { get; set; }
        public System.UInt16 DataExecutionPrevention_SupportPolicy { get; set; }
        public bool Debug { get; set; }
        public string Description { get; set; }
        public bool Distributed { get; set; }
        public UInt32 EncryptionLevel { get; set; }
        public UInt16 ForegroundApplicationBoost { get; set; }
        public UInt64 FreePhysicalMemory { get; set; }
        public UInt64 FreeSpaceInPagingFiles { get; set; }
        public UInt64 FreeVirtualMemory { get; set; }

        /// <summary>
        /// Datetime
        /// </summary>
        public string InstallDate { get; set; }
        public UInt32 LargeSystemCache { get; set; }

        /// <summary>
        /// Datetime
        /// </summary>
        public string LastBootUpTime { get; set; }

        /// <summary>
        /// Datetime
        /// </summary>
        public string LocalDateTime { get; set; }
        public string Locale { get; set; }
        public string Manufacturer { get; set; }
        public UInt32 MaxNumberOfProcesses { get; set; }
        public UInt64 MaxProcessMemorySize { get; set; }
        public string[] MUILanguages { get; set; }
        public string Name { get; set; }
        public UInt32 NumberOfLicensedUsers { get; set; }
        public UInt32 NumberOfProcesses { get; set; }
        public UInt32 NumberOfUsers { get; set; }
        public UInt32 OperatingSystemSKU { get; set; }
        public string Organization { get; set; }
        public string OSArchitecture { get; set; }
        public UInt32 OSLanguage { get; set; }
        public UInt32 OSProductSuite { get; set; }
        public UInt16 OSType { get; set; }
        public string OtherTypeDescription { get; set; }
        public bool PAEEnabled { get; set; }
        public string PlusProductID { get; set; }
        public string PlusVersionNumber { get; set; }
        public bool PortableOperatingSystem { get; set; }
        public bool Primary { get; set; }
        public UInt32 ProductType { get; set; }
        public string RegisteredUser { get; set; }
        public string SerialNumber { get; set; }
        public UInt16 ServicePackMajorVersion { get; set; }
        public UInt16 ServicePackMinorVersion { get; set; }
        public UInt64 SizeStoredInPagingFiles { get; set; }
        public string Status { get; set; }
        public UInt32 SuiteMask { get; set; }
        public string SystemDevice { get; set; }
        public string SystemDirectory { get; set; }
        public string SystemDrive { get; set; }
        public UInt64 TotalSwapSpaceSize { get; set; }
        public UInt64 TotalVirtualMemorySize { get; set; }
        public UInt64 TotalVisibleMemorySize { get; set; }
        public string Version { get; set; }
        public string WindowsDirectory { get; set; }
        public UInt16 QuantumLength { get; set; }
        public UInt16 QuantumType { get; set; }
    }
}

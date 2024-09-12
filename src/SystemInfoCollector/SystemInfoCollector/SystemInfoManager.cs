using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TianXiaTech.SystemInfoCollector.Util;
using TianXiaTech.SystemInfoCollector.WMIObject;

namespace TianXiaTech.SystemInfoCollector
{
    public class SystemInfoManager
    {
        public static Win32OperatingSystem CollectOperatingSystem()
        {
            var dic = WMIHelper.GetAllWmiProperty("Win32_OperatingSystem");
            return ReflectionUtil.DictionaryMapToObject<Win32OperatingSystem>(dic);
        }

        public static List<Win32Service> CollectServices()
        {
            List<Win32Service> services = new List<Win32Service>();
            var list = WMIHelper.GetWmiPropertyList("Win32_Service");
            return list.Select(x => ReflectionUtil.DictionaryMapToObject<Win32Service>(x)).ToList();
        }

        public static List<Win32Process> CollectProcesses()
        {
            List<Win32Process> services = new List<Win32Process>();
            var list = WMIHelper.GetWmiPropertyList("Win32_Process");
            return list.Select(x => ReflectionUtil.DictionaryMapToObject<Win32Process>(x)).ToList();
        }
    }
}

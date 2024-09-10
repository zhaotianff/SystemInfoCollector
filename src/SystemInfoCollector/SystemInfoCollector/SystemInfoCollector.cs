using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SystemInfoCollector.Util;
using SystemInfoCollector.WMIObject;

namespace SystemInfoCollector
{
    public class SystemInfoCollector
    {
        public static Win32OperatingSystem CollectOperatingSystem()
        {
            var dic = WMIHelper.GetAllWmiProperty("Win32_OperatingSystem");
            return ReflectionUtil.DictionaryMapToObject<Win32OperatingSystem>(dic);
        }

        public static List<Win32Service> CollectServices()
        {
            List<Win32Service> services = new List<Win32Service>();
            var list = WMIHelper.GetWmiPropertyList("Win32_Service ");
            return list.Select(x => ReflectionUtil.DictionaryMapToObject<Win32Service>(x)).ToList();
        }
    }
}

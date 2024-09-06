using System;
using System.Diagnostics;
using SystemInfoCollector.Util;
using SystemInfoCollector.WMIObject;

namespace SystemInfoCollector
{
    public class SystemInfoCollector
    {
        public static OperatingSystemInfo CollectOperatingSystem()
        {
            var dic = WMIHelper.GetAllWmiProperty("Win32_OperatingSystem");
            return ReflectionUtil.DictionaryMapToObject<OperatingSystemInfo>(dic);
        }
    }
}

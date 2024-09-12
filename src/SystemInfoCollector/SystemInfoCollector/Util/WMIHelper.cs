using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace TianXiaTech.SystemInfoCollector.Util
{
    internal class WMIHelper
    {
        internal static Dictionary<string, object> GetAllWmiProperty(string wmiObject)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from " + wmiObject);

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
            {
                foreach (PropertyData property in managementObject.Properties)
                {
                    dic.Add(property.Name, property.Value ?? null);
                }
            }

            return dic;
        }

        internal static List<Dictionary<string, object>> GetWmiPropertyList(string wmiObject)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("select * from " + wmiObject);

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                foreach (PropertyData property in managementObject.Properties)
                {
                    dic.Add(property.Name, property.Value ?? null);
                }
                list.Add(dic);
            }

            return list;
        }
    }
}

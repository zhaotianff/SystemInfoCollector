using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemInfoCollector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace SystemInfoCollector.Tests
{
    [TestClass()]
    public class SystemInfoCollectorTests
    {
        [TestMethod()]
        public void CollectOperatingSystemTest()
        {
            var info = SystemInfoCollector.CollectServices();
            Assert.IsTrue(true);


            var format = "yyyyMMddHHmmss";
            //CultureInfo culture = CultureInfo.InvariantCulture;
            //DateTime newDate = DateTime.ParseExact(info.InstallDate, format, culture);

            //https://learn.microsoft.com/zh-cn/windows/win32/wmisdk/cim-datetime
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class HighAvNodeTests : TestBase
    {
        [TestMethod]
        public void TestHighAvNodeGet()
        {
            TestGet<HighAvFilterOptions>(null, "HighAvailabilityNodes");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

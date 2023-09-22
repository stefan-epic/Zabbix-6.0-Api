using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class DiscoveredHostTests : TestBase
    {
        [TestMethod]
        public void TestDHostGet()
        {
            TestGet<DiscoveredHostFilterOptions>(null, "DiscoveredHosts");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

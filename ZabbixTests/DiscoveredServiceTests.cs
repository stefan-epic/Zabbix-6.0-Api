using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class DiscoveredServiceTests : TestBase
    {
        [TestMethod]
        public void TestDServiceGet()
        {
            TestGet<DiscoveredServiceFilterOptions>(null, "DiscoveredServices");
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

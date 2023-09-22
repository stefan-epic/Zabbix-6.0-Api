using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class DiscoveryCheckTests : TestBase
    {
        [TestMethod]
        public void TestDCheckGet()
        {
            TestGet<DiscoveryCheckServiceFilterOptions>(null, "DiscoveryChecks");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class DiscoveryRuleTests : TestBase
    {
        [TestMethod]
        public void TestDRuleGet()
        {
            DiscoveryRule d = new DiscoveryRule() {
                Name = "TestDRule" + Id,
                IpRange = "192.168.1.1-255",
                DiscoveryChecks = new List<DiscoveryCheck>() {
                    new DiscoveryCheck() {
                        Type = 9,
                        Key = "system.uname",
                        Ports = "10050",
                        Uniq = 0
                    }
                }
            };
            TestCycle(d, "DiscoveryRules");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

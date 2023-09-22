using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class LldRuleTests : TestBase
    {
        [TestMethod]
        public void TestLldRuleCycle()
        {
            LldRule r = new LldRule() {
                Name = "testlldrule"+Id,
                Key = "vfs.fs.discovery",
                HostId = TestHost.EntityId,
                Type = 19,
                Delay = "30s",
                Url = "abc.com"
            };
            TestCycle(r, "LldRules");
        }

        public override void SetUp()
        {
            SetUpTestGroupAndHost();
        }

        public override void CleanUp()
        {
            DestroyTestGroupAndHost();
        }
    }
}

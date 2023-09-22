using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class WebScenarioTests : TestBase
    {

        [TestMethod]
        public void TestWebScenarioCycle()
        {
            WebScenarioStep step = new WebScenarioStep("TestStep", 0, "abc.com");
            WebScenario scenario = new WebScenario("TestScenario"+Id, TestHost.EntityId, new List<WebScenarioStep>(){step});
            TestCycle(scenario, "WebScenarios", new(){"HostId"});
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

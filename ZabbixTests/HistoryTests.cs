using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class HistoryTests : TestBase
    {
        [TestMethod]
        public void TestHistoryGet()
        {
            HistoryFilterOptions options = new HistoryFilterOptions() {
                History = 3,
                HostIds = TestHost.EntityId
            };
            TestGet(options, "History");
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

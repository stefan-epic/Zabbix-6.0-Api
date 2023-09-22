using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ItemTests : TestBase
    {
        [TestMethod]
        public void TestItemCycle()
        {
            var item = new Item("1m", TestHost.EntityId, null, "TestKey","TestItem", 19, "abc.com", 0);
            TestCycle(item, "Items", new List<string>(){"HostId"});
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

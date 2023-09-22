using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

//TODO: Event.ackknowledge
namespace ZabbixIntegrationTests
{
    [TestClass]
    public class EventTests : TestBase
    {
        [TestMethod]
        public void TestEventGet()
        {
            TestGet<EventFilterOptions>(null, "Events");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

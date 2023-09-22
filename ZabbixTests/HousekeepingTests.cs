using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class HousekeepingTests : TestBase
    {
        [TestMethod]
        public void TestHouseKeeping()
        {
            var obj = (Housekeeping)TestGet<HousekeepingFilterOptions>(null, "Housekeeping");
            Assert.IsNotNull(obj);
            Housekeeping h = new Housekeeping() {
                HkEventsMode = obj.HkEventsMode
            };
            var strings = Core.Housekeeping.Update(h).ToList();
            Assert.IsNotNull(strings);
            Assert.AreEqual(strings[0], "hk_events_mode");
        }
        public override void SetUp()
        {  
        }

        public override void CleanUp()
        {
        }
    }
}

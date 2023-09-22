using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class MaintenanceTests : TestBase
    {
        [TestMethod]
        public void TestMaintenanceCycle()
        {
            Host t = new Host() {
                EntityId = TestHost.EntityId
            };

            Maintenance m = new Maintenance() {
                Hosts = new List<Host>() {
                    t
                },
                Name = "TestMaintenance"+Id,
                ActiveSince = "1358844540",
                ActiveTill = "1390466940",
                TimePeriods = new List<TimePeriod>() {
                    new() {
                        Period = 3600,
                        TimePeriodType = 3,
                        StartTime = 64800,
                        Every = 1,
                        DayOfWeek = 64
                    }
                }

            };

            TestCycle(m, "Maintenance");
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

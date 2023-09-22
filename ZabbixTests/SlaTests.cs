using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class SlaTests : TestBase
    {
        [TestMethod]
        public void TestSlaCycle()
        {
            SLA s = new() {
                Name = "Testsla" + Id,
                SLO = 99.1f,
                Period = 1,
                Timezone = "America/Toronto",
                Description = "test",
                EffectiveDate = 1672444800,
                Status = 1,
                Schedules = new List<SLASchedule>() {
                    new() {
                        PeriodFrom = 0,
                        PeriodTo = 601200
                    }
                },
                Tags = new List<SLAServiceTag>() {
                    new() {
                        TagName = "t",
                        Value = "v",
                        Operator = 0
                    }
                }
            };
            TestCycle(s, "SLAs");
        }
        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class CorrelationTests : TestBase
    {
        [TestMethod]
        public void TestCorrelationCycle()
        {
            Correlation c = new Correlation() {
                Filter = new() {
                    EvalType = 0,
                    Conditions = new List<CorrelationFilterCondition>() {
                        new() {
                            Type = 1,
                            Tag = "ok"
                        }
                    }
                },
                Operations = new List<CorrelationOperation>() {
                    new() {
                        Type = 0
                    }
                },
                Name = "Test"+Id
            };
            TestCycle(c, "Correlations");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

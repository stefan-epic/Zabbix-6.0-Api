using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ProblemTests : TestBase
    {
        [TestMethod]
        public void TestProblemGet()
        {
            TestGet<ProblemFilterOptions>(null, "Problems");
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

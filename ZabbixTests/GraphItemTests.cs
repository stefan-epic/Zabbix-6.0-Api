using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class GraphItemTests : TestBase
    {
        [TestMethod]
        public void TestGraphItemGet()
        {
            TestGet<GraphItemFilterOptions>(null, "GraphItems");
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

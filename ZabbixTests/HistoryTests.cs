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
            TestGet<HistoryFilterOptions>(null, "History");
        }
        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

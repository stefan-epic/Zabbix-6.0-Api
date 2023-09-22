using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class AlertTests : TestBase
    {
        [TestMethod]
        public void TestAlertGet()
        {
           var alerts =  TestGet<AlertFilterOptions>(null, "Alerts");   
           Assert.IsNotNull(alerts);

        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

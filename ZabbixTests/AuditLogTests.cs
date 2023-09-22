using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;
using Zabbix.Services.CrudServices;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class AuditLogTests : TestBase
    {
        [TestMethod]
        public void TestAuditLogGet()
        {
            TestGet<AuditLogFilterOptions>(null, "AuditLogs");
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

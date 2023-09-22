using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class AutoRegistrationTests : TestBase
    {
        [TestMethod]
        public void TestAutoRegistration()
        {
            var obj = (Autoregistration)TestGet<AutoregistrationFilterOptions>(null, "AutoRegistration");
            bool isSuccess = Core.AutoRegistration.Update(obj);
            Assert.IsTrue(isSuccess);
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

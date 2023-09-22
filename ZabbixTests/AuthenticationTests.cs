using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class AuthenticationTests : TestBase
    {
        [TestMethod]
        public void TestAuthentication()
        {
            var obj = (Authentication)TestGet<AuthenticationFilterOptions>(null, "Authentication");
            Assert.IsNotNull(obj.HttpAuthEnabled);

            Authentication a = new() {
                HttpAuthEnabled = obj.HttpAuthEnabled
            };
            var strings = Core.Authentication.Update(a).ToArray();
            Assert.IsNotNull(strings);
            Assert.AreEqual(strings[0], "http_auth_enabled");

        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class SettingsTests : TestBase
    {
        [TestMethod]
        public void TestSettings()
        {
            var obj = (Settings)TestGet<SettingsFilterOptions>(null, "Settings");
            Settings s = new Settings() {
                LoginAttempts = obj.LoginAttempts
            };
            var strings = Core.Settings.Update(s).ToList();
            Assert.IsNotNull(strings);
            Assert.AreEqual(strings[0], "login_attempts");
        }
        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

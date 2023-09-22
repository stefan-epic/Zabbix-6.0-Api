using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ApIinfoTests : TestBase
    {
        [TestMethod]
        public void TestApiInfo()
        {
            string version = Core.ApiInfo.GetVersion();
            Assert.IsNotNull(version);
            Assert.AreNotEqual(version, String.Empty);
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

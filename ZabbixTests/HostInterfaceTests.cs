using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class HostInterfaceTests : TestBase
    {
        [TestMethod]
        public void TestHostInterfaceCycle()
        {
            HostInterface h = new HostInterface() {
                HostId = TestHost.EntityId,
                Main = 1,
                Type = 1,
                Useip = 1,
                Ip = "127.0.0.1",
                Dns = "",
                Port = "24000",
            };
            TestCycle(h, "HostInterfaces", new () {"HostId"});
        }
        public override void SetUp()
        {
            SetUpTestGroupAndHost();
        }

        public override void CleanUp()
        {
            DestroyTestGroupAndHost();
        }
    }
}

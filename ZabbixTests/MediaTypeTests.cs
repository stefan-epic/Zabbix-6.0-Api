using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class MediaTypeTests : TestBase
    {
        [TestMethod]
        public void TestMediaTypeCycle()
        {
            MediaType m = new() {
                Type = 1,
                Name = "Testmediatype" + Id,
                ExecPath = "ls",
                ExecParams = "",
                MaxAttempts = 5,
                AttemptInterval = "11s"
            };
            TestCycle(m, "MediaTypes");
        }

        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class MapTests : TestBase
    {
        [TestMethod]
        public void TestMapCycle()
        {
            Map m = new Map() {
                Name = "testmap"+Id,
                Width = 600,
                Height = 600
            };
            TestCycle(m, "Maps");
        }

        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

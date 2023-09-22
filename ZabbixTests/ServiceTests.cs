using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ServiceTests : TestBase
    {
        [TestMethod]
        public void TestServiceCycle()
        {
            Service s = new() {
                Name = "TestService" + Id,
                Algorithm = 1,
                SortOrder = 1
            };
            TestCycle(s, "Services");
        }
        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

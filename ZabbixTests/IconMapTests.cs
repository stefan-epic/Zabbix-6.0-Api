using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class IconMapTests : TestBase
    {
        [TestMethod]
        public void TestIconMapCycle()
        {
            IconMap im = new() {
                Name = "testIcon" + Id,
                DefaultIconId = "2",
                IconMappings = new List<IconMapping>() {
                    new() {
                        InventoryLink = 1,
                        Expression = "server",
                        IconId = "3"
                    }
                }
            };
            TestCycle(im, "IconMaps");
        }

        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

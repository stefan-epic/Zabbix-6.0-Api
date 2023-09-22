using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class GraphTests : TestBase
    {
        [TestMethod]
        public void TestGraphCycle()
        {
            Graph g = new Graph() {
                Name = "TestGraph"+Id,
                Width = 900,
                Height = 200,
                GraphItems = new List<GraphItem>() {
                    new GraphItem() {
                        ItemId = TestItem.EntityId,
                        Color = "00AA00"
                    }
                }
            };
            TestCycle(g, "Graphs");
        }
        public override void SetUp()
        {
            SetUpTestGroupAndHost();
            SetUpTestItem(TestHost);
        }

        public override void CleanUp()
        {
            DestroyTestGroupAndHost();
            //Don't need to destroy test item because it gets automatically deleted with the host
        }
    }
}

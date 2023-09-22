using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class TemplateTests : TestBase
    {
        [TestMethod]
        public void TestTemplateCycle()
        {
            HostGroup h = new HostGroup() {
                EntityId = TestGroup.EntityId
            };
            Template t = new Template() {
                Host = "templatetest" + Id,
                Groups = new List<HostGroup>() { h },
            };
            TestCycle(t, "Templates");
        }
        public override void SetUp()
        {
            SetUpTestGroup();
        }

        public override void CleanUp()
        {
            DestroyTestGroup();
        }
    }
}

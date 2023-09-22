using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class RoleTests : TestBase
    {
        [TestMethod]
        public void TestRoleCycle()
        {
            Role r = new Role() {
                Name = "TestRole"+Id,
                type = 1,
                Rule = new(){
                    Ui = new List<UiElement>() {
                        new UiElement() {
                            Name = "monitoring.hosts",
                            Status = 0
                        }
                    }
                }
            };
            TestCycle(r, "Roles");
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

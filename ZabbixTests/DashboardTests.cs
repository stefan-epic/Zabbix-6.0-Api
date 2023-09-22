using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class DashboardTests : TestBase
    {
        [TestMethod]
        public void TestDashboardCycle()
        {
            var dashboard = new Dashboard() {
                Name = "TestDashboard" + Id,
                AutoStart = "1",
                Pages = new List<DashboardPage>() {
                    new DashboardPage() {
                        Widgets = new List<DashboardWidget>() {
                            new DashboardWidget() {
                                Type = "problems",
                                X = "0",
                                Y = "0",
                                Width = "12",
                                Height = "5",
                                ViewMode = "0",
                                Fields = new List<DashboardField>() {
                                    new DashboardField() {
                                        Type = "1",
                                        Name = "tags.tag.0",
                                        Value = "service"
                                    }
                                }
                            }
                        }
                    }
                },
                UserGroups = new List<DashboardUserGroup>() {
                    new() {
                        UserGroupId = TestUserGroup.EntityId,
                        Permission = 2
                    }
                },
                Users = new List<DashboardUser>() {
                    new() {
                        UserId = "1",
                        Permission = 3
                    }
                }
            };

            TestCycle(dashboard, "Dashboards");

        }
        public override void SetUp()
        {
            SetUpTestUserGroup();
        }

        public override void CleanUp()
        {
            DestroyTestUserGroup();
        }
    }
}

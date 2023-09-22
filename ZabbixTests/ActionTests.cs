using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = Zabbix.Entities.Action;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ActionTests : TestBase
    {
        [TestMethod]
        public void TestActionCycle()
        {
            Action action = new Action("30m", 0, "Test"+Id);
            ActionOperation op = new(0) {
                OperationType = 0,
                EscStepFrom = 1,
                EscStepTo = 1,
                OpMessageGroup = new List<OperationMessageGroup>() {
                    new() {
                        UserGroupId = TestUserGroup.EntityId
                    }
                },
                OpMessage = new()
                {
                    DefaultMessage = 1,
                    MediaTypeId = "1",
                }
        };

            action.Operations = new List<ActionOperation>() {op};
            
            TestCycle(action, "Actions", new List<string>(){"EventSource"});
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    

    [TestClass]
    public class UserTests : TestBase
    {

        [TestMethod]
        public void TestUserCycle()
        {
            TestUserGroup.Name = null;
            User u = new User(Id.ToString(), new List<UserGroup>(){TestUserGroup}, "username", "3");
            TestCycle(u, "Users");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class TokenTests : TestBase
    {

        [TestMethod]
        public void TestTokenCycle()
        {
            Token t = new Token() {
                Name = "TestToken"+Id,
                UserId = "1"
            };
            TestCycle(t, "Tokens", new List<string>(){"UserId"});
        }

        public override void SetUp()
        {
        }

        public override void CleanUp()
        {
        }
    }
}

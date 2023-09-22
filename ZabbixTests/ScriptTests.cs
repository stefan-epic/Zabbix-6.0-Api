using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class ScriptTests : TestBase
    {
        [TestMethod]
        public void TestScriptCycle()
        {
            Script s = new Script() {
                Name = "Testscript" + Id,
                Command = "ls",
                Confirmation = "haha test",
                Scope = 2,
                Type = 0
            };
            TestCycle(s, "Scripts");
        }
        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

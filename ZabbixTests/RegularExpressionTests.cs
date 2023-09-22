using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    [TestClass]
    public class RegularExpressionTests : TestBase
    {
        [TestMethod]
        public void TestRegexCycle()
        {
            RegexObject r = new() {
                Name = "TestRegex" + Id,
                Expressions = new List<Expressions>() {
                    new Expressions() {
                        Expression = "a",
                        ExpressionType = 4
                    }
                }
            };
            TestCycle(r, "Regex");
        }
        public override void SetUp()
        {
            
        }

        public override void CleanUp()
        {
        }
    }
}

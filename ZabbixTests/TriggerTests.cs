using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixIntegrationTests
{
    public class TriggerTests : TestBase //TODO:
    {

        public override void SetUp()
        {
            SetUpTestGroupAndHost();
        }

        public override void CleanUp()
        {
            DestroyTestGroupAndHost();
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ActionService : CrudService<Entities.Action, ActionInclude, ActionProperties, ActionService.ActionResult>
    {
        public class ActionResult : BaseResult
        {
            [JsonProperty("actionids")]
            public override string[] Ids { get; set; }
        }

        public ActionService(ICore core) : base(core, "action")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<ActionProperties, ActionInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum ActionProperties
    {
    }

    public enum ActionInclude
    {
    }
}

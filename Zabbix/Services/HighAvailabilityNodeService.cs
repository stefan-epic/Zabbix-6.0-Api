using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class HighAvailabilityNodeService : GetService<HighAvailabilityNode, GetHighAvFilter>
    {
        public HighAvailabilityNodeService(ICore core) : base(core, "hanode")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class GetHighAvFilter : GetFilter
    {
        [JsonProperty("ha_nodeids")]
        public IList<string>? HaNodeIds { get; set; }
    }

}

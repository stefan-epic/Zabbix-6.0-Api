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
    public class HighAvailabilityNodeService : GetService<HighAvailabilityNode, HighAvFilterOptions>
    {
        public HighAvailabilityNodeService(ICore core) : base(core, "hanode")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class HighAvFilterOptions : FilterOptions
    {
        [JsonProperty("ha_nodeids")]
        public object? HaNodeIds { get; set; }
    }

}

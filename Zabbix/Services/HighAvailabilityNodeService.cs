using Newtonsoft.Json;
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

        
    }

    public class HighAvFilterOptions : FilterOptions
    {
        [JsonProperty("ha_nodeids")]
        public object? HaNodeIds { get; set; }
    }

}

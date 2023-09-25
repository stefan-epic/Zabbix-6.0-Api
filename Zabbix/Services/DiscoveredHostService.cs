using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveredHostService : GetService<DiscoveredHost, DiscoveredHostFilterOptions>
    {
        public DiscoveredHostService(ICore core) : base(core, "dhost")
        {
        }
        

    }

    public class DiscoveredHostFilterOptions : FilterOptions
    {
        [JsonProperty("dhostids")]
        public object? DiscoveredHostIds { get; set; }

        [JsonProperty("druleids")]
        public object? DiscoveryRuleIds { get; set; }

        [JsonProperty("dserviceids")]
        public object? DiscoveredServiceIds { get; set; }

        [JsonProperty("selectDRules")]
        public ZabbixQuery? SelectDiscoveryRules { get; set; }

        [JsonProperty("selectDServices")]
        public ZabbixQuery? SelectDiscoveredServices { get; set; }
    }

    public enum DiscoveredHostInclude
    {
        selectDRules,
        selectDServices
    }
}

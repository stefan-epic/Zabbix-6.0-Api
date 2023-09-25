using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveredServiceService : GetService<DiscoveredService, DiscoveredServiceFilterOptions>
    {
        public DiscoveredServiceService(ICore core) : base(core, "dservice")
        {
        }


    }

    public class DiscoveredServiceFilterOptions : FilterOptions
    {
        [JsonProperty("dserviceids")]
        public object? DiscoveredServiceIds { get; set; }

        [JsonProperty("dhostids")]
        public object? DiscoveredHostIds { get; set; }

        [JsonProperty("dcheckids")]
        public object? DiscoveryCheckIds { get; set; }

        [JsonProperty("druleids")]
        public object? DiscoveryRuleIds { get; set; }

        [JsonProperty("selectDRules")]
        public ZabbixQuery? SelectDiscoveryRules { get; set; }

        [JsonProperty("selectDHosts")]
        public ZabbixQuery? SelectDiscoveredHosts { get; set; }

        [JsonProperty("selectHosts")]
        public ZabbixQuery? SelectHosts { get; set; }
    }

    public enum DiscoveredServiceInclude
    {
    }
}

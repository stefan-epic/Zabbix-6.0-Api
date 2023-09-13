using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveryCheckService : GetService<DiscoveryCheck, DiscoveryCheckServiceFilterOptions>
    {
        public DiscoveryCheckService(ICore core) : base(core, "dcheck")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class DiscoveryCheckServiceFilterOptions : FilterOptions
    {
        [JsonProperty("dcheckids")]
        public object? DiscoveryCheckIds { get; set; }

        [JsonProperty("druleids")]
        public object? DiscoveryRuleIds { get; set; }

        [JsonProperty("dserviceids")]
        public object? DiscoveredServiceIds { get; set; }
    }

    public enum DiscoveryCheckInclude
    {
    }
}

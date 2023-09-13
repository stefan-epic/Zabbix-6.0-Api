using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveredHostService : GetService<DiscoveredHost, GetDiscoveredHostFilter>
    {
        public DiscoveredHostService(ICore core) : base(core, "dhost")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class GetDiscoveredHostFilter : GetFilter
    {
        [JsonProperty("dhostids")]
        public IList<string>? DiscoveredHostIds { get; set; }

        [JsonProperty("druleids")]
        public IList<string>? DiscoveryRuleIds { get; set; }

        [JsonProperty("dserviceids")]
        public IList<string>? DiscoveredServiceIds { get; set; }

        [JsonProperty("selectDRules")]
        public IList<string>? SelectDiscoveryRules { get; set; }

        [JsonProperty("selectDServices")]
        public IList<string>? SelectDiscoveredServices { get; set; }
    }

    public enum DiscoveredHostInclude
    {
        selectDRules,
        selectDServices
    }
}

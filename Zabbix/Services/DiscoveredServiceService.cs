using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveredServiceService : GetService<DiscoveredService, GetDiscoveredServiceFilter>
    {
        public DiscoveredServiceService(ICore core) : base(core, "dservice")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class GetDiscoveredServiceFilter : GetFilter
    {
        [JsonProperty("dserviceids")]
        public IList<string>? DiscoveredServiceIds { get; set; }

        [JsonProperty("dhostids")]
        public IList<string>? DiscoveredHostIds { get; set; }

        [JsonProperty("dcheckids")]
        public IList<string>? DiscoveryCheckIds { get; set; }

        [JsonProperty("druleids")]
        public IList<string>? DiscoveryRuleIds { get; set; }

        [JsonProperty("selectDRules")]
        public IList<string>? SelectDiscoveryRules { get; set; }

        [JsonProperty("selectDHosts")]
        public IList<string>? SelectDiscoveredHosts { get; set; }

        [JsonProperty("selectHosts")]
        public IList<string>? SelectHosts { get; set; }
    }

    public enum DiscoveredServiceInclude
    {
    }
}

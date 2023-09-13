using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveryCheckService : GetService<DiscoveryCheck, GetDiscoveryCheckServiceFilter>
    {
        public DiscoveryCheckService(ICore core) : base(core, "dcheck")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class GetDiscoveryCheckServiceFilter : GetFilter
    {
        [JsonProperty("dcheckids")]
        public IList<string>? DiscoveryCheckIds { get; set; }

        [JsonProperty("druleids")]
        public IList<string>? DiscoveryRuleIds { get; set; }

        [JsonProperty("dserviceids")]
        public IList<string>? DiscoveredServiceIds { get; set; }
    }

    public enum DiscoveryCheckInclude
    {
    }
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class DiscoveryRuleService : CrudService<DiscoveryRule, GetDiscoveryRuleFilter, DiscoveryRuleService.DiscoveryRuleResult>
{
    public DiscoveryRuleService(ICore core) : base(core, "drule")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class DiscoveryRuleResult : BaseResult
    {
        [JsonProperty("druleids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetDiscoveryRuleFilter : GetFilter
{
    [JsonProperty("dcheckids")]
    public IList<string>? DiscoveryCheckIds { get; set; }

    [JsonProperty("druleids")]
    public IList<string>? DiscoveryRuleIds { get; set; }

    [JsonProperty("dserviceids")]
    public IList<string>? DiscoveredServiceIds { get; set; }
}

public enum DiscoverRuleInclude
{
    selectDHosts,
    selectDChecks
}
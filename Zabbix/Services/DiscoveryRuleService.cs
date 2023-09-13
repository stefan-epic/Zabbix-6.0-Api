using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class DiscoveryRuleService : CrudService<DiscoveryRule, DiscoveryRuleFilterOptions, DiscoveryRuleService.DiscoveryRuleResult>
{
    public DiscoveryRuleService(ICore core) : base(core, "drule")
    {
    }

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class DiscoveryRuleResult : BaseResult
    {
        [JsonProperty("druleids")] public override IList<string>? Ids { get; set; }
    }
}

public class DiscoveryRuleFilterOptions : FilterOptions
{
    [JsonProperty("dcheckids")]
    public object? DiscoveryCheckIds { get; set; }

    [JsonProperty("druleids")]
    public object? DiscoveryRuleIds { get; set; }

    [JsonProperty("dserviceids")]
    public object? DiscoveredServiceIds { get; set; }
}

public enum DiscoverRuleInclude
{
    selectDHosts,
    selectDChecks
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class DiscoveryRuleService : CrudService<DiscoveryRule, DiscoverRuleInclude, DiscoverRuleProperties,
    DiscoveryRuleService.DiscoveryRuleResult>
{
    public DiscoveryRuleService(ICore core) : base(core, "drule")
    {
    }

    protected override Dictionary<string, object>? BuildParams(
        RequestFilter<DiscoverRuleProperties, DiscoverRuleInclude>? filter = null,
        Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class DiscoveryRuleResult : BaseResult
    {
        [JsonProperty("druleids")] public override IList<string>? Ids { get; set; }
    }
}

public enum DiscoverRuleInclude
{
    selectDHosts,
    selectDChecks
}
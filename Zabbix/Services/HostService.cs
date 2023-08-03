using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;
//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/host/get
//Todo: maybe add all of the fields above

public class HostService : CrudService<Host, HostInclude, HostProperties, HostService.HostResult>
{
    public HostService(ICore core) : base(core, "host")
    {
    }

    protected override Dictionary<string, object> BuildParams(
        RequestFilter<HostProperties, HostInclude> filter = null, Dictionary<string, object> @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class HostResult : BaseResult
    {
        [JsonProperty("hostids")] public override string[] Ids { get; set; }
    }
}

public enum HostInclude
{
    selectDiscoveries,
    selectDiscoveryRule,
    selectGraphs,
    selectGroups,
    selectHostDiscovery,
    selectHttpTests,
    selectInterfaces,
    selectInventory,
    selectItems,
    selectMacros,
    selectParentTemplates,
    selectDashboards,
    selectTags,
    selectInheritedTags,
    selectTriggers,
    selectValueMaps,
    selectWithMonitoredItems
}
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;
using ZabbixApi.Helper;

namespace Zabbix.Services;
//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/host/get
//Todo: maybe add all of the fields above

public class HostService : MassCrudService<Host, HostInclude, HostProperties, HostService.HostResult>
{
    public HostService(ICore core) : base(core, "host")
    {
    }

    protected override Dictionary<string, object> BuildParams(RequestFilter<HostProperties, HostInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class HostResult : BaseResult
    {
        [JsonProperty("hostids")] public override IList<string>? Ids { get; set; }
    }
    /*
    public override Dictionary<string, object> BuildMassParams(IEnumerable<Host> entities, Host properties, Dictionary<string, object>? @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, object>();

        var hostIds = entities.ToList().Select(host => host.EntityId).ToList();
        @params.Add("hosts", hostIds);

        JsonSerializerSettings settings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };


        //TODO: doesnt work
        @params.Add("params", JsonConvert.SerializeObject(properties, settings));

        return @params;
    }
    */
    public override Dictionary<string, object> BuildMassParams(IEnumerable<Host> entities, Dictionary<HostProperties, object> properties, Dictionary<string, object>? @params = null)
    {
        throw new NotImplementedException();
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
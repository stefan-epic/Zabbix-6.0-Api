using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;


public class HostService : MassCrudService<Host, GetHostFilter, HostService.HostResult>
{
    public HostService(ICore core) : base(core, "host")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
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
    public override Dictionary<string, object> BuildMassParams(IEnumerable<Host> entities, Dictionary<HostProperties, object> properties, Dictionary<string, object>? @params = null)
    {
        throw new NotImplementedException();
    }
    */

}

public class GetHostFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("dserviceids")]
    public IList<string>? DServiceIds { get; set; }

    [JsonProperty("graphids")]
    public IList<string>? GraphIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("httptestids")]
    public IList<string>? HttpTestIds { get; set; }

    [JsonProperty("interfaceids")]
    public IList<string>? InterfaceIds { get; set; }

    [JsonProperty("itemids")]
    public IList<string>? ItemIds { get; set; }

    [JsonProperty("maintenanceids")]
    public IList<string>? MaintenanceIds { get; set; }

    [JsonProperty("monitored_hosts")]
    public bool? MonitoredHosts { get; set; }

    [JsonProperty("proxy_hosts")]
    public bool? ProxyHosts { get; set; }

    [JsonProperty("proxyids")]
    public IList<string>? ProxyIds { get; set; }

    [JsonProperty("templated_hosts")]
    public bool? TemplatedHosts { get; set; }

    [JsonProperty("templateids")]
    public IList<string>? TemplateIds { get; set; }

    [JsonProperty("triggerids")]
    public IList<string>? TriggerIds { get; set; }

    [JsonProperty("with_items")]
    public bool? WithItems { get; set; }

    [JsonProperty("with_item_prototypes")]
    public bool? WithItemPrototypes { get; set; }

    [JsonProperty("with_simple_graph_item_prototypes")]
    public bool? WithSimpleGraphItemPrototypes { get; set; }

    [JsonProperty("with_graphs")]
    public bool? WithGraphs { get; set; }

    [JsonProperty("with_graph_prototypes")]
    public bool? WithGraphPrototypes { get; set; }

    [JsonProperty("with_httptests")]
    public bool? WithHttpTests { get; set; }

    [JsonProperty("with_monitored_httptests")]
    public bool? WithMonitoredHttpTests { get; set; }

    [JsonProperty("with_monitored_items")]
    public bool? WithMonitoredItems { get; set; }

    [JsonProperty("with_monitored_triggers")]
    public bool? WithMonitoredTriggers { get; set; }

    [JsonProperty("with_simple_graph_items")]
    public bool? WithSimpleGraphItems { get; set; }

    [JsonProperty("with_triggers")]
    public bool? WithTriggers { get; set; }

    [JsonProperty("withProblemsSuppressed")]
    public bool? WithProblemsSuppressed { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("severities")]
    public IList<int>? Severities { get; set; }

    [JsonProperty("tags")]
    public IList<string>? Tags { get; set; }

    [JsonProperty("inheritedTags")]
    public bool? InheritedTags { get; set; }

    [JsonProperty("selectDiscoveries")]
    public IList<string>? SelectDiscoveries { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public IList<string>? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectGraphs")]
    public IList<string>? SelectGraphs { get; set; }

    [JsonProperty("selectHostDiscovery")]
    public IList<string>? SelectHostDiscovery { get; set; }

    [JsonProperty("selectHostGroups")]
    public IList<string>? SelectHostGroups { get; set; }

    [JsonProperty("selectHttpTests")]
    public IList<string>? SelectHttpTests { get; set; }

    [JsonProperty("selectInterfaces")]
    public IList<string>? SelectInterfaces { get; set; }

    [JsonProperty("selectInventory")]
    public IList<string>? SelectInventory { get; set; }

    [JsonProperty("selectItems")]
    public IList<string>? SelectItems { get; set; }

    [JsonProperty("selectMacros")]
    public IList<string>? SelectMacros { get; set; }

    [JsonProperty("selectParentTemplates")]
    public IList<string>? SelectParentTemplates { get; set; }

    [JsonProperty("selectDashboards")]
    public IList<string>? SelectDashboards { get; set; }

    [JsonProperty("selectTags")]
    public IList<string>? SelectTags { get; set; }

    [JsonProperty("selectInheritedTags")]
    public IList<string>? SelectInheritedTags { get; set; }

    [JsonProperty("selectTriggers")]
    public IList<string>? SelectTriggers { get; set; }

    [JsonProperty("selectValueMaps")]
    public IList<string>? SelectValueMaps { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    [JsonProperty("searchInventory")]
    public IDictionary<string, string>? SearchInventory { get; set; }

    #endregion
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;


public class HostService : MassCrudService<Host, HostFilterOptions, HostService.HostResult>
{
    public HostService(ICore core) : base(core, "host")
    {
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


        @params.Add("params", JsonConvert.SerializeObject(properties, settings));

        return @params;
    }
    public override Dictionary<string, object> BuildMassParams(IEnumerable<Host> entities, Dictionary<HostProperties, object> properties, Dictionary<string, object>? @params = null)
    {
        throw new NotImplementedException();
    }
    */

}

public class HostFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("dserviceids")]
    public object? DServiceIds { get; set; }

    [JsonProperty("graphids")]
    public object? GraphIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("httptestids")]
    public object? HttpTestIds { get; set; }

    [JsonProperty("interfaceids")]
    public object? InterfaceIds { get; set; }

    [JsonProperty("itemids")]
    public object? ItemIds { get; set; }

    [JsonProperty("maintenanceids")]
    public object? MaintenanceIds { get; set; }

    [JsonProperty("monitored_hosts")]
    public bool? MonitoredHosts { get; set; }

    [JsonProperty("proxy_hosts")]
    public bool? ProxyHosts { get; set; }

    [JsonProperty("proxyids")]
    public object? ProxyIds { get; set; }

    [JsonProperty("templated_hosts")]
    public bool? TemplatedHosts { get; set; }

    [JsonProperty("templateids")]
    public object? TemplateIds { get; set; }

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

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
    public object? Tags { get; set; }

    [JsonProperty("inheritedTags")]
    public bool? InheritedTags { get; set; }

    [JsonProperty("selectDiscoveries")]
    public ZabbixQuery? SelectDiscoveries { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public ZabbixQuery? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectGraphs")]
    public ZabbixQuery? SelectGraphs { get; set; }

    [JsonProperty("selectHostDiscovery")]
    public ZabbixQuery? SelectHostDiscovery { get; set; }

    [JsonProperty("selectHostGroups")]
    public ZabbixQuery? SelectHostGroups { get; set; }

    [JsonProperty("selectHttpTests")]
    public ZabbixQuery? SelectHttpTests { get; set; }

    [JsonProperty("selectInterfaces")]
    public ZabbixQuery? SelectInterfaces { get; set; }

    [JsonProperty("selectInventory")]
    public ZabbixQuery? SelectInventory { get; set; }

    [JsonProperty("selectItems")]
    public ZabbixQuery? SelectItems { get; set; }

    [JsonProperty("selectMacros")]
    public ZabbixQuery? SelectMacros { get; set; }

    [JsonProperty("selectParentTemplates")]
    public ZabbixQuery? SelectParentTemplates { get; set; }

    [JsonProperty("selectDashboards")]
    public ZabbixQuery? SelectDashboards { get; set; }

    [JsonProperty("selectTags")]
    public ZabbixQuery? SelectTags { get; set; }

    [JsonProperty("selectInheritedTags")]
    public ZabbixQuery? SelectInheritedTags { get; set; }

    [JsonProperty("selectTriggers")]
    public ZabbixQuery? SelectTriggers { get; set; }

    [JsonProperty("selectValueMaps")]
    public ZabbixQuery? SelectValueMaps { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    [JsonProperty("searchInventory")]
    public IDictionary<string, string>? SearchInventory { get; set; }

    #endregion
}
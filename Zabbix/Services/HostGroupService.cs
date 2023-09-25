using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class HostGroupService : MassCrudService<HostGroup, HostGroupFilterOptions, HostGroupService.HostGroupResult>
{
    public HostGroupService(ICore core) : base(core, "hostgroup")
    {
    }


    public class HostGroupResult : BaseResult
    {
        [JsonProperty("groupids")] public override IList<string>? Ids { get; set; }
    }
    /*
    public override Dictionary<string, object> BuildMassParams(IEnumerable<HostGroup> entities, HostGroup properties, Dictionary<string, object>? @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, object>();

        var hostIds = entities.ToList().Select(host => host.EntityId).ToList();
        @params.Add("groups", hostIds);

        JsonSerializerSettings settings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        @params.Add("params", JsonConvert.SerializeObject(properties, settings));

        return @params;
    }

    public override Dictionary<string, object> BuildMassParams(IEnumerable<HostGroup> entities, Dictionary<HostGroupProperties, object> properties, Dictionary<string, object>? @params = null)
    {
        throw new NotImplementedException();
    }
    */

}

public class HostGroupFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("graphids")]
    public object? GraphIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("maintenanceids")]
    public object? MaintenanceIds { get; set; }

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

    [JsonProperty("with_graphs")]
    public bool? WithGraphs { get; set; }

    [JsonProperty("with_graph_prototypes")]
    public bool? WithGraphPrototypes { get; set; }

    [JsonProperty("with_hosts")]
    public bool? WithHosts { get; set; }

    [JsonProperty("with_httptests")]
    public bool? WithHttpTests { get; set; }

    [JsonProperty("with_items")]
    public bool? WithItems { get; set; }

    [JsonProperty("with_item_prototypes")]
    public bool? WithItemPrototypes { get; set; }

    [JsonProperty("with_simple_graph_item_prototypes")]
    public bool? WithSimpleGraphItemPrototypes { get; set; }

    [JsonProperty("with_monitored_httptests")]
    public bool? WithMonitoredHttpTests { get; set; }

    [JsonProperty("with_monitored_hosts")]
    public bool? WithMonitoredHosts { get; set; }

    [JsonProperty("with_monitored_items")]
    public bool? WithMonitoredItems { get; set; }

    [JsonProperty("with_monitored_triggers")]
    public bool? WithMonitoredTriggers { get; set; }

    [JsonProperty("with_simple_graph_items")]
    public bool? WithSimpleGraphItems { get; set; }

    [JsonProperty("with_triggers")]
    public bool? WithTriggers { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public ZabbixQuery? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectGroupDiscovery")]
    public ZabbixQuery? SelectGroupDiscovery { get; set; }

    [JsonProperty("selectHosts")]
    public ZabbixQuery? SelectHosts { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion

}
//TODO:


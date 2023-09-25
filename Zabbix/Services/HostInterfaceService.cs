using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class HostInterfaceService : CrudService<HostInterface, HostInterfaceFilterOptions,HostInterfaceService.HostInterfaceResult>
{
    public HostInterfaceService(ICore core) : base(core, "hostinterface")
    {
    }

    public class HostInterfaceResult : BaseResult
    {
        [JsonProperty("interfaceids")] public override IList<string>? Ids { get; set; }
    }
}

public class HostInterfaceFilterOptions : FilterOptions
{
    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("interfaceids")]
    public object? InterfaceIds { get; set; }

    [JsonProperty("itemids")]
    public object? ItemIds { get; set; }

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

    [JsonProperty("selectItems")]
    public ZabbixQuery? SelectItems { get; set; }

    [JsonProperty("selectHosts")]
    public ZabbixQuery? SelectHosts { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }
}

public enum HostInterfaceInclude
{
    selectHosts,
    selectItems
}
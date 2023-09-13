using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//TODO
public class HostInterfaceService : CrudService<HostInterface, GetHostInterfaceFilter,HostInterfaceService.HostInterfaceResult>
{
    public HostInterfaceService(ICore core) : base(core, "hostinterface")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter)
    {
        return BaseBuildParams(filter);
    }

    public class HostInterfaceResult : BaseResult
    {
        [JsonProperty("interfaceids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetHostInterfaceFilter : GetFilter
{
    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("interfaceids")]
    public IList<string>? InterfaceIds { get; set; }

    [JsonProperty("itemids")]
    public IList<string>? ItemIds { get; set; }

    [JsonProperty("triggerids")]
    public IList<string>? TriggerIds { get; set; }

    [JsonProperty("selectItems")]
    public IList<string>? SelectItems { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }
}

public enum HostInterfaceInclude
{
    selectHosts,
    selectItems
}
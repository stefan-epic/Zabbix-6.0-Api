using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ItemService : CrudService<Item, GetItemFilter, ItemService.ItemResult>
{
    public ItemService(ICore core) : base(core, "item")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class ItemResult : BaseResult
    {
        [JsonProperty("itemids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetItemFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("itemids")]
    public IList<string>? ItemIds { get; set; }

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("templateids")]
    public IList<string>? TemplateIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("proxyids")]
    public IList<string>? ProxyIds { get; set; }

    [JsonProperty("interfaceids")]
    public IList<string>? InterfaceIds { get; set; }

    [JsonProperty("graphids")]
    public IList<string>? GraphIds { get; set; }

    [JsonProperty("triggerids")]
    public IList<string>? TriggerIds { get; set; }

    [JsonProperty("webitems")]
    public bool? WebItems { get; set; }

    [JsonProperty("inherited")]
    public bool? Inherited { get; set; }

    [JsonProperty("templated")]
    public bool? Templated { get; set; }

    [JsonProperty("monitored")]
    public bool? Monitored { get; set; }

    [JsonProperty("group")]
    public string? Group { get; set; }

    [JsonProperty("host")]
    public string? Host { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("with_triggers")]
    public bool? WithTriggers { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectInterfaces")]
    public IList<string>? SelectInterfaces { get; set; }

    [JsonProperty("selectTriggers")]
    public IList<string>? SelectTriggers { get; set; }

    [JsonProperty("selectGraphs")]
    public IList<string>? SelectGraphs { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public IList<string>? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectItemDiscovery")]
    public IList<string>? SelectItemDiscovery { get; set; }

    [JsonProperty("selectPreprocessing")]
    public IList<string>? SelectPreprocessing { get; set; }

    [JsonProperty("selectTags")]
    public bool? SelectTags { get; set; }

    [JsonProperty("selectValueMap")]
    public bool? SelectValueMap { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion
}

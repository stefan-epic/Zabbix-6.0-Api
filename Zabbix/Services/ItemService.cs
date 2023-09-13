using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ItemService : CrudService<Item, ItemFilterOptions, ItemService.ItemResult>
{
    public ItemService(ICore core) : base(core, "item")
    {
    }

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class ItemResult : BaseResult
    {
        [JsonProperty("itemids")] public override IList<string>? Ids { get; set; }
    }
}

public class ItemFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("itemids")]
    public object? ItemIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("templateids")]
    public object? TemplateIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("proxyids")]
    public object? ProxyIds { get; set; }

    [JsonProperty("interfaceids")]
    public object? InterfaceIds { get; set; }

    [JsonProperty("graphids")]
    public object? GraphIds { get; set; }

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

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
    public object? SelectHosts { get; set; }

    [JsonProperty("selectInterfaces")]
    public object? SelectInterfaces { get; set; }

    [JsonProperty("selectTriggers")]
    public object? SelectTriggers { get; set; }

    [JsonProperty("selectGraphs")]
    public object? SelectGraphs { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public object? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectItemDiscovery")]
    public object? SelectItemDiscovery { get; set; }

    [JsonProperty("selectPreprocessing")]
    public object? SelectPreprocessing { get; set; }

    [JsonProperty("selectTags")]
    public bool? SelectTags { get; set; }

    [JsonProperty("selectValueMap")]
    public bool? SelectValueMap { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class
    TemplateService : CrudService<Template, TemplateFilterOptions, TemplateService.TemplateResult>
{
    public TemplateService(ICore core) : base(core, "template")
    {
    }

    public class TemplateResult : BaseResult
    {
        [JsonProperty("templateids")] public override IList<string>? Ids { get; set; }
    }
}

public class TemplateFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("templateids")]
    public object? TemplateIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("parentTemplateids")]
    public object? ParentTemplateIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("graphids")]
    public object? GraphIds { get; set; }

    [JsonProperty("itemids")]
    public object? ItemIds { get; set; }

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

    [JsonProperty("with_items")]
    public bool? WithItems { get; set; }

    [JsonProperty("with_triggers")]
    public bool? WithTriggers { get; set; }

    [JsonProperty("with_graphs")]
    public bool? WithGraphs { get; set; }

    [JsonProperty("with_httptests")]
    public bool? WithHttpTests { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("selectGroups")]
    public object? SelectGroups { get; set; }

    [JsonProperty("selectTags")]
    public object? SelectTags { get; set; }

    [JsonProperty("selectHosts")]
    public object? SelectHosts { get; set; }

    [JsonProperty("selectTemplates")]
    public object? SelectTemplates { get; set; }

    [JsonProperty("selectParentTemplates")]
    public object? SelectParentTemplates { get; set; }

    [JsonProperty("selectHttpTests")]
    public object? SelectHttpTests { get; set; }

    [JsonProperty("selectItems")]
    public object? SelectItems { get; set; }

    [JsonProperty("selectDiscoveries")]
    public object? SelectDiscoveries { get; set; }

    [JsonProperty("selectTriggers")]
    public object? SelectTriggers { get; set; }

    [JsonProperty("selectGraphs")]
    public object? SelectGraphs { get; set; }

    [JsonProperty("selectMacros")]
    public object? SelectMacros { get; set; }

    [JsonProperty("selectDashboards")]
    public object? SelectDashboards { get; set; }

    [JsonProperty("selectValueMaps")]
    public object? SelectValueMaps { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion
}


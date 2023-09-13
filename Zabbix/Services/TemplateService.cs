using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class
    TemplateService : CrudService<Template, GetTemplateFilter, TemplateService.TemplateResult>
{
    public TemplateService(ICore core) : base(core, "template")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter)
    {
        return BaseBuildParams(filter);
    }

    public class TemplateResult : BaseResult
    {
        [JsonProperty("templateids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetTemplateFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("templateids")]
    public IList<string>? TemplateIds { get; set; }

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("parentTemplateids")]
    public IList<string>? ParentTemplateIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("graphids")]
    public IList<string>? GraphIds { get; set; }

    [JsonProperty("itemids")]
    public IList<string>? ItemIds { get; set; }

    [JsonProperty("triggerids")]
    public IList<string>? TriggerIds { get; set; }

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
    public IList<string>? SelectGroups { get; set; }

    [JsonProperty("selectTags")]
    public IList<string>? SelectTags { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectTemplates")]
    public IList<string>? SelectTemplates { get; set; }

    [JsonProperty("selectParentTemplates")]
    public IList<string>? SelectParentTemplates { get; set; }

    [JsonProperty("selectHttpTests")]
    public IList<string>? SelectHttpTests { get; set; }

    [JsonProperty("selectItems")]
    public IList<string>? SelectItems { get; set; }

    [JsonProperty("selectDiscoveries")]
    public IList<string>? SelectDiscoveries { get; set; }

    [JsonProperty("selectTriggers")]
    public IList<string>? SelectTriggers { get; set; }

    [JsonProperty("selectGraphs")]
    public IList<string>? SelectGraphs { get; set; }

    [JsonProperty("selectMacros")]
    public IList<string>? SelectMacros { get; set; }

    [JsonProperty("selectDashboards")]
    public IList<string>? SelectDashboards { get; set; }

    [JsonProperty("selectValueMaps")]
    public IList<string>? SelectValueMaps { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion
}


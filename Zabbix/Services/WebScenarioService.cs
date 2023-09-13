using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class WebScenarioService : CrudService<WebScenario, GetWebScenarioFilter, WebScenarioService.WebScenarioResult>
{
    public WebScenarioService(ICore core) : base(core, "httptest")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class WebScenarioResult : BaseResult
    {
        [JsonProperty("httptestids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetWebScenarioFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("httptestids")]
    public IList<string>? HttpTestIds { get; set; }

    [JsonProperty("inherited")]
    public bool? Inherited { get; set; }

    [JsonProperty("monitored")]
    public bool? Monitored { get; set; }

    [JsonProperty("templated")]
    public bool? Templated { get; set; }

    [JsonProperty("templateids")]
    public IList<string>? TemplateIds { get; set; }

    [JsonProperty("expandName")]
    public bool? ExpandName { get; set; }

    [JsonProperty("expandStepName")]
    public bool? ExpandStepName { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectSteps")]
    public IList<string>? SelectSteps { get; set; }

    [JsonProperty("selectTags")]
    public IList<string>? SelectTags { get; set; }

    #endregion
}

public enum WebScenarioInclude
{
    selectHosts,
    selectSteps,
    selectTags
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class WebScenarioService : CrudService<WebScenario, WebScenarioFilterOptions, WebScenarioService.WebScenarioResult>
{
    public WebScenarioService(ICore core) : base(core, "httptest")
    {
    }


    public class WebScenarioResult : BaseResult
    {
        [JsonProperty("httptestids")] public override IList<string>? Ids { get; set; }
    }
}

public class WebScenarioFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("httptestids")]
    public object? HttpTestIds { get; set; }

    [JsonProperty("inherited")]
    public bool? Inherited { get; set; }

    [JsonProperty("monitored")]
    public bool? Monitored { get; set; }

    [JsonProperty("templated")]
    public bool? Templated { get; set; }

    [JsonProperty("templateids")]
    public object? TemplateIds { get; set; }

    [JsonProperty("expandName")]
    public bool? ExpandName { get; set; }

    [JsonProperty("expandStepName")]
    public bool? ExpandStepName { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("selectHosts")]
    public ZabbixQuery? SelectHosts { get; set; }

    [JsonProperty("selectSteps")]
    public ZabbixQuery? SelectSteps { get; set; }

    [JsonProperty("selectTags")]
    public ZabbixQuery? SelectTags { get; set; }

    #endregion
}

public enum WebScenarioInclude
{
    selectHosts,
    selectSteps,
    selectTags
}
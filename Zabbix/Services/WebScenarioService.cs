using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class WebScenarioService : CrudService<WebScenario, WebScenarioInclude, WebScenarioProperties,
    WebScenarioService.WebScenarioResult>
{
    public WebScenarioService(ICore core) : base(core, "httptest")
    {
    }

    protected override Dictionary<string, object>? BuildParams(RequestFilter<WebScenarioProperties, WebScenarioInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class WebScenarioResult : BaseResult
    {
        [JsonProperty("httptestids")] public override IList<string>? Ids { get; set; }
    }
}

public enum WebScenarioInclude
{
    selectHosts,
    selectSteps,
    selectTags
}
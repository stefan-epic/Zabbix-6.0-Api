using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class
    TemplateService : CrudService<Template, TemplateInclude, TemplateProperties, TemplateService.TemplateResult>
{
    public TemplateService(ICore core) : base(core, "template")
    {
    }

    protected override Dictionary<string, object> BuildParams(RequestFilter<TemplateProperties, TemplateInclude>? filter,
        Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class TemplateResult : BaseResult
    {
        [JsonProperty("templateids")] public override IList<string>? Ids { get; set; }
    }
}

//TODO:
public enum TemplateInclude
{
    selectGroups,
    selectTags,
    selectHosts,
    selectTemplates,
    selectParentTemplates,
    selectHttpTests,
    selectItems,
    selectDiscoveries,
    selectTriggers,
    selectGraphs,
    selectMacros,
    selectDashboards,
    selectValueMaps
}
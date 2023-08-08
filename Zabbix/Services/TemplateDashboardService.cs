using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TemplateDashboardService : CrudService<TemplateDashboard, TemplateDashboardInclude, TemplateDashboardProperties, TemplateDashboardService.TemplateDashboardResult>
    {


        public TemplateDashboardService(ICore core) : base(core, "templatedashboard")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<TemplateDashboardProperties, TemplateDashboardInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class TemplateDashboardResult : BaseResult
        {
            [JsonProperty("templatedashboardids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum TemplateDashboardInclude
    {
    }
}

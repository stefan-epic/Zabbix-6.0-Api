using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TemplateDashboardService : CrudService<TemplateDashboard, GetTemplateDashboardFilter, TemplateDashboardService.TemplateDashboardResult>
    {


        public TemplateDashboardService(ICore core) : base(core, "templatedashboard")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class TemplateDashboardResult : BaseResult
        {
            [JsonProperty("templatedashboardids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetTemplateDashboardFilter : GetFilter
    {
        [JsonProperty("dashboardids")]
        public IList<string>? DashboardIds { get; set; }

        [JsonProperty("templateids")]
        public IList<string>? TemplateIds { get; set; }

        [JsonProperty("selectPages")]
        public IList<string>? SelectPages { get; set; }
    }

}

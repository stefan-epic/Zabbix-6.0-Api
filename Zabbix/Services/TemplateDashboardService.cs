using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TemplateDashboardService : CrudService<TemplateDashboard, TemplateDashboardFilterOptions, TemplateDashboardService.TemplateDashboardResult>
    {


        public TemplateDashboardService(ICore core) : base(core, "templatedashboard")
        {
        }

   
        public class TemplateDashboardResult : BaseResult
        {
            [JsonProperty("templatedashboardids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class TemplateDashboardFilterOptions : FilterOptions
    {
        [JsonProperty("dashboardids")]
        public object? DashboardIds { get; set; }

        [JsonProperty("templateids")]
        public object? TemplateIds { get; set; }

        [JsonProperty("selectPages")]
        public ZabbixQuery? SelectPages { get; set; }
    }

}

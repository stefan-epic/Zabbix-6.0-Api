using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DashboardService : CrudService<Dashboard, DashboardFilterOptions, DashboardService.DashboardResult> //TODO
    {
        public DashboardService(ICore core) : base(core, "dashboard")
        {

        }

        public class DashboardResult : BaseResult
        {
            [JsonProperty("dashboardids")] public override IList<string>? Ids { get; set; }
        }

    }

    public class DashboardFilterOptions : FilterOptions
    {
        public object? DashboardIds { get; set; }
        public bool? SelectPages { get; set; }
        public bool? SelectUsers { get; set; }
        public bool? SelectUserGroups { get; set; }
    }

}

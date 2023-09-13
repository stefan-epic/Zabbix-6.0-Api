using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class MaintenanceService : CrudService<Maintenance, GetMaintenanceFilter, MaintenanceService.MaintenanceResult>
    {

        public MaintenanceService(ICore core) : base(core, "maintenance")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class MaintenanceResult : BaseResult
        {
            [JsonProperty("maintenanceids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetMaintenanceFilter : GetFilter
    {
        [JsonProperty("groupids")]
        public IList<string>? GroupIds { get; set; }

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("maintenanceids")]
        public IList<string>? MaintenanceIds { get; set; }

        [JsonProperty("selectGroups")]
        public string? SelectGroups { get; set; }

        [JsonProperty("selectHosts")]
        public string? SelectHosts { get; set; }

        [JsonProperty("selectTags")]
        public string? SelectTags { get; set; }

        [JsonProperty("selectTimeperiods")]
        public string? SelectTimeperiods { get; set; }
    }

    public enum MaintenanceInclude
    {
        selectGroups,
        selectHosts,
        selectTags,
        selectTimeperiods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class MaintenanceService : CrudService<Maintenance, MaintenanceInclude, MaintenanceProperties, MaintenanceService.MaintenanceResult>
    {

        public MaintenanceService(ICore core) : base(core, "maintenance")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<MaintenanceProperties, MaintenanceInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class MaintenanceResult : BaseResult
        {
            [JsonProperty("maintenanceids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum MaintenanceInclude
    {
        selectGroups,
        selectHosts,
        selectTags,
        selectTimeperiods
    }
}

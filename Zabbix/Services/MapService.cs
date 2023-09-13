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
    public class MapService : CrudService<Map, MapFilterOptions, MapService.MapResult>
    {
        public MapService(ICore core, string className) : base(core, className) { }
        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class MapResult : BaseResult
        {
            [JsonProperty("sysmapids")]public override IList<string>? Ids { get; set; }
        }

    }

    public class MapFilterOptions : FilterOptions { }
}

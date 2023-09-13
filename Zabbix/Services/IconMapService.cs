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
    public class IconMapService : CrudService<IconMap, GetIconMapFilter, IconMapService.IconMapResult>
    {
        public IconMapService(ICore core) : base(core, "iconmap")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class IconMapResult : BaseResult
        {
            [JsonProperty("iconmapids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetIconMapFilter : GetFilter
    {
        [JsonProperty("iconmapids")]
        public IList<string>? IconMapIds { get; set; }

        [JsonProperty("sysmapids")]
        public IList<string>? SysMapIds { get; set; }

        [JsonProperty("selectMappings")]
        public IList<string>? SelectMappings { get; set; }
    }

}

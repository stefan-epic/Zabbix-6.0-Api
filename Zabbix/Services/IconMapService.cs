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
    public class IconMapService : CrudService<IconMap, IconMapFilterOptions, IconMapService.IconMapResult>
    {
        public IconMapService(ICore core) : base(core, "iconmap")
        {
        }


        public class IconMapResult : BaseResult
        {
            [JsonProperty("iconmapids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class IconMapFilterOptions : FilterOptions
    {
        [JsonProperty("iconmapids")]
        public object? IconMapIds { get; set; }

        [JsonProperty("sysmapids")]
        public object? SysMapIds { get; set; }

        [JsonProperty("selectMappings")]
        public object? SelectMappings { get; set; }
    }

}

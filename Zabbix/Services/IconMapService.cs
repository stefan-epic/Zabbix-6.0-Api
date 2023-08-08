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
    public class IconMapService : CrudService<IconMap, IconMapInclude, IconMapProperties, IconMapService.IconMapResult>
    {
        public IconMapService(ICore core) : base(core, "iconmap")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<IconMapProperties, IconMapInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class IconMapResult : BaseResult
        {
            [JsonProperty("iconmapids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum IconMapInclude
    {
        selectMappings
    }
}

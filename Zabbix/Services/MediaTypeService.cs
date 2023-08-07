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
    public class MediaTypeService : CrudService<MediaType, MediaTypeInclude, MediaTypeProperties, MediaTypeService.MediaTypeResult>
    {

        public MediaTypeService(ICore core) : base(core, "mediatype")
        {
            
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<MediaTypeProperties, MediaTypeInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class MediaTypeResult : BaseResult
        {
            [JsonProperty("mediatypeids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum MediaTypeInclude
    {
    }
}

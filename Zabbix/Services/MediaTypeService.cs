using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class MediaTypeService : CrudService<MediaType, GetMediaTypeFilter, MediaTypeService.MediaTypeResult>
    {

        public MediaTypeService(ICore core) : base(core, "mediatype")
        {

        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class MediaTypeResult : BaseResult
        {
            [JsonProperty("mediatypeids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetMediaTypeFilter : GetFilter
    {
        [JsonProperty("mediatypeids")]
        public IList<string>? MediaTypeIds { get; set; }

        [JsonProperty("mediaids")]
        public IList<string>? MediaIds { get; set; }

        [JsonProperty("userids")]
        public IList<string>? UserIds { get; set; }

        [JsonProperty("selectMessageTemplates")]
        public string? SelectMessageTemplates { get; set; }

        [JsonProperty("selectUsers")]
        public string? SelectUsers { get; set; }
    }

    
}

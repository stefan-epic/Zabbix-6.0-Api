using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class MediaTypeService : CrudService<MediaType, MediaTypeFilterOptions, MediaTypeService.MediaTypeResult>
    {

        public MediaTypeService(ICore core) : base(core, "mediatype")
        {

        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class MediaTypeResult : BaseResult
        {
            [JsonProperty("mediatypeids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class MediaTypeFilterOptions : FilterOptions
    {
        [JsonProperty("mediatypeids")]
        public object? MediaTypeIds { get; set; }

        [JsonProperty("mediaids")]
        public object? MediaIds { get; set; }

        [JsonProperty("userids")]
        public object? UserIds { get; set; }

        [JsonProperty("selectMessageTemplates")]
        public string? SelectMessageTemplates { get; set; }

        [JsonProperty("selectUsers")]
        public string? SelectUsers { get; set; }
    }

    
}

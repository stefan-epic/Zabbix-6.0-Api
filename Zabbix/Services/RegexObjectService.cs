using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class RegexObjectService : CrudService<RegexObject, GetRegexObjectFilter, RegexObjectService.RegexObjectResult>
    {

        public RegexObjectService(ICore core) : base(core, "regexp")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class RegexObjectResult : BaseResult
        {
            [JsonProperty("regexpids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetRegexObjectFilter : GetFilter
    {
        [JsonProperty("regexpids")]
        public IList<string>? RegularExpressionIds { get; set; }

        [JsonProperty("selectExpressions")]
        public IList<string>? SelectExpressions { get; set; }
    }

    public enum RegexObjectInclude
    {
    }
}

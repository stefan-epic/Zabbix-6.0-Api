using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ValueMapService : CrudService<ValueMap, GetValueFilter, ValueMapService.ValueMapResult>
    {

        public ValueMapService(ICore core) : base(core, "valuemap")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class ValueMapResult : BaseResult
        {
            [JsonProperty("valuemapids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetValueFilter : GetFilter
    {
        [JsonProperty("valuemapids")]
        public IList<string>? ValueMapIds { get; set; }

        [JsonProperty("selectMappings")]
        public IList<string>? SelectMappings { get; set; }
    }

    public enum ValueMapInclude
    {
        selectMappings
    }
}

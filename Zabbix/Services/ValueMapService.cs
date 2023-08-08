using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ValueMapService : CrudService<ValueMap, ValueMapInclude, ValueMapProperties, ValueMapService.ValueMapResult>
    {

        public ValueMapService(ICore core) : base(core, "valuemap")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<ValueMapProperties, ValueMapInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class ValueMapResult : BaseResult
        {
            [JsonProperty("valuemapids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum ValueMapInclude
    {
        selectMappings
    }
}

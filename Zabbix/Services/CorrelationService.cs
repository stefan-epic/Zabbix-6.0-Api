using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class CorrelationService : CrudService<Correlation, CorrelationFilterOptions, CorrelationService.CorrelationResult>
    {
        

        public CorrelationService(ICore core ) : base(core, "correlation")
        {

        }

        public class CorrelationResult : BaseResult
        {
            [JsonProperty("correlationids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class CorrelationFilterOptions : FilterOptions
    {
        [JsonProperty("correlationids")]
        public object? CorrelationIds { get; set; }

        [JsonProperty("selectFilter")]
        public object? SelectFilter { get; set; }

        [JsonProperty("selectOperations")]
        public object? SelectOperations { get; set; }
    }

}

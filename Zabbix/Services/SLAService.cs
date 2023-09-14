using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    //TODO implemement SLAsli method
    public class SlaService : CrudService<SLA, SlaFilterOptions, SlaService.SlaResult>
    {

        public SlaService(ICore core) : base(core, "sla")
        {
        }

        public class SlaResult : BaseResult
        {
            [JsonProperty("slaids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class SlaFilterOptions : FilterOptions
    {
        [JsonProperty("slaids")]
        public object? SlaIds { get; set; }

        [JsonProperty("serviceids")]
        public object? ServiceIds { get; set; }

        [JsonProperty("selectSchedule")]
        public object? SelectSchedule { get; set; }

        [JsonProperty("selectExcludedDowntimes")]
        public object? SelectExcludedDowntimes { get; set; }

        [JsonProperty("selectServiceTags")]
        public object? SelectServiceTags { get; set; }
    }

}

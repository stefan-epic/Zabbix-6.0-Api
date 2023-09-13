using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    //TODO implemement SLAsli method
    public class SlaService : CrudService<SLA, GetSlaFilter, SlaService.SlaResult>
    {

        public SlaService(ICore core) : base(core, "sla")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class SlaResult : BaseResult
        {
            [JsonProperty("slaids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetSlaFilter : GetFilter
    {
        [JsonProperty("slaids")]
        public IList<string>? SlaIds { get; set; }

        [JsonProperty("serviceids")]
        public IList<string>? ServiceIds { get; set; }

        [JsonProperty("selectSchedule")]
        public IList<string>? SelectSchedule { get; set; }

        [JsonProperty("selectExcludedDowntimes")]
        public IList<string>? SelectExcludedDowntimes { get; set; }

        [JsonProperty("selectServiceTags")]
        public IList<string>? SelectServiceTags { get; set; }
    }

}

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

        public SlaSliResult GetSli(string slaId, int? periodFrom, int? periodTo, IEnumerable<int>? periods, IEnumerable<string>? serviceIds)
        {
            Dictionary<string, object?> @params = new Dictionary<string, object?>() { { "slaid", slaId } };

            if(periodFrom != null)
                @params.Add("period_from", periodFrom);
            if (periodTo != null)
                @params.Add("period_to", periodTo);
            if (periods != null)
                @params.Add("periods", periods);
            if (serviceIds != null)
                @params.Add("serviceids", serviceIds);

            return Core.SendRequest<SlaSliResult>(@params, "sla.getsli");
        }

        public async Task<SlaSliResult> GetSliAsync(string slaId, int? periodFrom, int? periodTo, IEnumerable<int>? periods, IEnumerable<string>? serviceIds)
        {
            Dictionary<string, object?> @params = new Dictionary<string, object?>() { { "slaid", slaId } };

            if (periodFrom != null)
                @params.Add("period_from", periodFrom);
            if (periodTo != null)
                @params.Add("period_to", periodTo);
            if (periods != null)
                @params.Add("periods", periods);
            if (serviceIds != null)
                @params.Add("serviceids", serviceIds);

            return await Core.SendRequestAsync<SlaSliResult>(@params, "sla.getsli");
        }

        public class SlaResult : BaseResult
        {
            [JsonProperty("slaids")]
            public override IList<string>? Ids { get; set; }
        }

        public class SlaSliResult
        {
            [JsonProperty("periods")] public IList<PeriodObj>? Periods { get; set; }
            [JsonProperty("serviceids")] public IList<string>? ServiceIds { get; set; }
            [JsonProperty("sli")] public IList<IList<SliData>>? SliDataList { get; set; }
        }

        public class SliData
        {
            [JsonProperty("uptime")]
            public int? Uptime { get; set; }

            [JsonProperty("downtime")]
            public int? Downtime { get; set; }

            [JsonProperty("sli")]
            public float? Sli { get; set; }

            [JsonProperty("error_budget")]
            public int? ErrorBudget { get; set; }

            [JsonProperty("excluded_downtimes")]
            public IList<ExcludedDowntime>? ExcludedDowntimes { get; set; }
        }

        public class ExcludedDowntime
        {
            [JsonProperty("name")]
            public string? Name { get; set; }

            [JsonProperty("period_from")]
            public DateTime? PeriodFrom { get; set; }

            [JsonProperty("period_to")]
            public DateTime? PeriodTo { get; set; }
        }
        public class PeriodObj
        {
            [JsonProperty("period_from")] public int? PeriodFrom { get; set; }
            [JsonProperty("period_to")] public int? PeriodTo { get; set; }
        }

    }


    public class SlaFilterOptions : FilterOptions
    {
        [JsonProperty("slaids")]
        public object? SlaIds { get; set; }

        [JsonProperty("serviceids")]
        public object? ServiceIds { get; set; }

        [JsonProperty("selectSchedule")]
        public ZabbixQuery? SelectSchedule { get; set; }

        [JsonProperty("selectExcludedDowntimes")]
        public ZabbixQuery? SelectExcludedDowntimes { get; set; }

        [JsonProperty("selectServiceTags")]
        public ZabbixQuery? SelectServiceTags { get; set; }
    }

}

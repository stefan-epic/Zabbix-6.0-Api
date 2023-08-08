using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    //TODO implemement SLAsli method
    public class SLAService : CrudService<SLA, SLAInclude, SLAProperties, SLAService.SLAResult>
    {

        public SLAService(ICore core) : base(core, "sla")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<SLAProperties, SLAInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class SLAResult : BaseResult
        {
            [JsonProperty("slaids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum SLAInclude
    {
        selectSchedule,
        selectExcludedDowntimes,
        selectServiceTags
    }
}

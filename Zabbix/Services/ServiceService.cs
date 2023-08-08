using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ServiceService : CrudService<Service, ServiceInclude, ServiceProperties, ServiceService.ServiceResult>
    {
        public ServiceService(ICore core) : base(core, "service")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<ServiceProperties, ServiceInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class ServiceResult : BaseResult
        {
            [JsonProperty("serviceids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum ServiceInclude
    {
        selectChildren,
        selectParents,
        selectTags,
        selectProblemEvents,
        selectProblemTags,
        selectStatusRules,
        selectStatusTimeline //TODO: <--- this

    }
}

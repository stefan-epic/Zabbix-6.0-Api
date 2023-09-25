using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ServiceService : CrudService<Service, ServiceFilterOptions, ServiceService.ServiceResult>
    {
        public ServiceService(ICore core) : base(core, "service")
        {
        }

        public class ServiceResult : BaseResult
        {
            [JsonProperty("serviceids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class ServiceFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("serviceids")]
        public object? ServiceIds { get; set; }

        [JsonProperty("parentids")]
        public object? ParentIds { get; set; }

        [JsonProperty("deep_parentids")]
        public bool? DeepParentIds { get; set; }

        [JsonProperty("childids")]
        public object? ChildIds { get; set; }

        [JsonProperty("evaltype")]
        public int? EvalType { get; set; }

        [JsonProperty("tags")]
        public IList<TagFilter>? Tags { get; set; }

        [JsonProperty("problem_tags")]
        public IList<TagFilter>? ProblemTags { get; set; }

        [JsonProperty("without_problem_tags")]
        public bool? WithoutProblemTags { get; set; }

        [JsonProperty("slaids")]
        public object? SlaIds { get; set; }

        [JsonProperty("selectChildren")]
        public ZabbixQuery? SelectChildren { get; set; }

        [JsonProperty("selectParents")]
        public ZabbixQuery? SelectParents { get; set; }

        [JsonProperty("selectTags")]
        public ZabbixQuery? SelectTags { get; set; }

        [JsonProperty("selectProblemEvents")]
        public ZabbixQuery? SelectProblemEvents { get; set; }

        [JsonProperty("selectProblemTags")]
        public ZabbixQuery? SelectProblemTags { get; set; }

        [JsonProperty("selectStatusRules")]
        public ZabbixQuery? SelectStatusRules { get; set; }

        [JsonProperty("selectStatusTimeline")]
        public IList<StatusTimelineFilter>? SelectStatusTimeline { get; set; }

        #endregion
    }
    public class StatusTimelineFilter
    {
        [JsonProperty("period_from")]
        public DateTime? PeriodFrom { get; set; }

        [JsonProperty("period_to")]
        public DateTime? PeriodTo { get; set; }
    }
}

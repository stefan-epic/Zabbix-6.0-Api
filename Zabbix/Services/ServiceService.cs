using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ServiceService : CrudService<Service, GetServiceFilter, ServiceService.ServiceResult>
    {
        public ServiceService(ICore core) : base(core, "service")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class ServiceResult : BaseResult
        {
            [JsonProperty("serviceids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetServiceFilter : GetFilter
    {
        #region Filter Properties

        [JsonProperty("serviceids")]
        public IList<string>? ServiceIds { get; set; }

        [JsonProperty("parentids")]
        public IList<string>? ParentIds { get; set; }

        [JsonProperty("deep_parentids")]
        public bool? DeepParentIds { get; set; }

        [JsonProperty("childids")]
        public IList<string>? ChildIds { get; set; }

        [JsonProperty("evaltype")]
        public int? EvalType { get; set; }

        [JsonProperty("tags")]
        public IList<TagFilter>? Tags { get; set; }

        [JsonProperty("problem_tags")]
        public IList<TagFilter>? ProblemTags { get; set; }

        [JsonProperty("without_problem_tags")]
        public bool? WithoutProblemTags { get; set; }

        [JsonProperty("slaids")]
        public IList<string>? SlaIds { get; set; }

        [JsonProperty("selectChildren")]
        public IList<string>? SelectChildren { get; set; }

        [JsonProperty("selectParents")]
        public IList<string>? SelectParents { get; set; }

        [JsonProperty("selectTags")]
        public IList<string>? SelectTags { get; set; }

        [JsonProperty("selectProblemEvents")]
        public IList<string>? SelectProblemEvents { get; set; }

        [JsonProperty("selectProblemTags")]
        public IList<string>? SelectProblemTags { get; set; }

        [JsonProperty("selectStatusRules")]
        public IList<string>? SelectStatusRules { get; set; }

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

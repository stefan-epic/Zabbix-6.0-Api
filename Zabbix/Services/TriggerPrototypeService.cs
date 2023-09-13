using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TriggerPrototypeService : CrudService<TriggerPrototype, GetTriggerPrototypeFilter, TriggerPrototypeService.TriggerPrototypeResult>
    {

        public TriggerPrototypeService(ICore core) : base(core, "triggerprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class TriggerPrototypeResult : BaseResult
        {
            [JsonProperty("triggerprototypeids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetTriggerPrototypeFilter : GetFilter
    {
        #region Filter Properties

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("discoveryids")]
        public IList<string>? DiscoveryIds { get; set; }

        [JsonProperty("functions")]
        public IList<string>? Functions { get; set; }

        [JsonProperty("group")]
        public string? Group { get; set; }

        [JsonProperty("groupids")]
        public IList<string>? GroupIds { get; set; }

        [JsonProperty("host")]
        public string? Host { get; set; }

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("maintenance")]
        public bool? Maintenance { get; set; }

        [JsonProperty("min_severity")]
        public int? MinSeverity { get; set; }

        [JsonProperty("monitored")]
        public bool? Monitored { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("templateids")]
        public IList<string>? TemplateIds { get; set; }

        [JsonProperty("triggerids")]
        public IList<string>? TriggerIds { get; set; }

        [JsonProperty("expandExpression")]
        public bool? ExpandExpression { get; set; }

        [JsonProperty("selectDependencies")]
        public IList<string>? SelectDependencies { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public IList<string>? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectFunctions")]
        public IList<string>? SelectFunctions { get; set; }

        [JsonProperty("selectGroups")]
        public IList<string>? SelectGroups { get; set; }

        [JsonProperty("selectHosts")]
        public IList<string>? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public IList<string>? SelectItems { get; set; }

        [JsonProperty("selectTags")]
        public IList<string>? SelectTags { get; set; }

        [JsonProperty("limitSelects")]
        public int? LimitSelects { get; set; }

        #endregion
    }

    public enum TriggerPrototypeInclude
    {
        selectDependencies,
        selectDiscoveryRule,
        selectFunctions,
        selectGroups,
        selectHosts,
        selectItems,
        selectTags
    }
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TriggerPrototypeService : CrudService<TriggerPrototype, TriggerPrototypeFilterOptions, TriggerPrototypeService.TriggerPrototypeResult>
    {

        public TriggerPrototypeService(ICore core) : base(core, "triggerprototype")
        {
        }

        public class TriggerPrototypeResult : BaseResult
        {
            [JsonProperty("triggerprototypeids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class TriggerPrototypeFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("discoveryids")]
        public object? DiscoveryIds { get; set; }

        [JsonProperty("functions")]
        public object? Functions { get; set; }

        [JsonProperty("group")]
        public string? Group { get; set; }

        [JsonProperty("groupids")]
        public object? GroupIds { get; set; }

        [JsonProperty("host")]
        public string? Host { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

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
        public object? TemplateIds { get; set; }

        [JsonProperty("triggerids")]
        public object? TriggerIds { get; set; }

        [JsonProperty("expandExpression")]
        public bool? ExpandExpression { get; set; }

        [JsonProperty("selectDependencies")]
        public ZabbixQuery? SelectDependencies { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public ZabbixQuery? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectFunctions")]
        public ZabbixQuery? SelectFunctions { get; set; }

        [JsonProperty("selectGroups")]
        public ZabbixQuery? SelectGroups { get; set; }

        [JsonProperty("selectHosts")]
        public ZabbixQuery? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public ZabbixQuery? SelectItems { get; set; }

        [JsonProperty("selectTags")]
        public ZabbixQuery? SelectTags { get; set; }

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

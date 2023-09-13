using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    //TODO Copy method
    public class LldRuleService : CrudService<LldRule, LldRuleFilterOptions, LldRuleService.LldRuleResult>
    {

        public LldRuleService(ICore core) : base(core, "discoveryrule")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class LldRuleResult : BaseResult
        {
            [JsonProperty("itemids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class LldRuleFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("groupids")]
        public object? GroupIds { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("interfaceids")]
        public object? InterfaceIds { get; set; }

        [JsonProperty("monitored")]
        public bool? Monitored { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("templateids")]
        public object? TemplateIds { get; set; }

        [JsonProperty("selectFilter")]
        public string? SelectFilter { get; set; }

        [JsonProperty("selectGraphs")]
        public object? SelectGraphs { get; set; }

        [JsonProperty("selectHostPrototypes")]
        public object? SelectHostPrototypes { get; set; }

        [JsonProperty("selectHosts")]
        public object? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public object? SelectItems { get; set; }

        [JsonProperty("selectTriggers")]
        public object? SelectTriggers { get; set; }

        [JsonProperty("selectLLDMacroPaths")]
        public string? SelectLLDMacroPaths { get; set; }

        [JsonProperty("selectPreprocessing")]
        public string? SelectPreprocessing { get; set; }

        [JsonProperty("selectOverrides")]
        public string? SelectOverrides { get; set; }

        [JsonProperty("filter")]
        public IDictionary<string, object>? Filter { get; set; }

        [JsonProperty("limitSelects")]
        public int? LimitSelects { get; set; }

        #endregion
    }


}

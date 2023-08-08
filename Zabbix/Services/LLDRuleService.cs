using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    //TODO Copy method
    public class LLDRuleService : CrudService<LLDRule, LLDRuleInclude, LLDRuleProperties, LLDRuleService.LLDRuleResult>
    {

        public LLDRuleService(ICore core) : base(core, "discoveryrule")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<LLDRuleProperties, LLDRuleInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class LLDRuleResult : BaseResult
        {
            [JsonProperty("itemids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum LLDRuleInclude
    {
        selectFilter,
        selectGraphs,
        selectHostPrototypes,
        selectHosts,
        selectItems,
        selectTriggers,
        selectLLDMacroPaths,
        selectPreprocessing,
        selectOverrides
    }
}

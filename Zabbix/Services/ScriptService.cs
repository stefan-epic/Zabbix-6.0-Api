using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ScriptService : CrudService<Script, ScriptInclude, ScriptProperties, ScriptService.ScriptResult>
    {


        public ScriptService(ICore core) : base(core, "script")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<ScriptProperties, ScriptInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class ScriptResult : BaseResult
        {
            [JsonProperty("scriptids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum ScriptInclude
    {
        selectActions,
        selectHosts,
        selectGroups
    }
}

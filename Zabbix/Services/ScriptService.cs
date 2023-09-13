using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ScriptService : CrudService<Script, GetScriptFilter, ScriptService.ScriptResult>
    {


        public ScriptService(ICore core) : base(core, "script")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class ScriptResult : BaseResult
        {
            [JsonProperty("scriptids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetScriptFilter : GetFilter
    {
        [JsonProperty("groupids")]
        public IList<string>? GroupIds { get; set; }

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("scriptids")]
        public IList<string>? ScriptIds { get; set; }

        [JsonProperty("usrgrpids")]
        public IList<string>? UsrgrpIds { get; set; }

        [JsonProperty("selectGroups")]
        public IList<string>? SelectGroups { get; set; }

        [JsonProperty("selectHosts")]
        public IList<string>? SelectHosts { get; set; }

        [JsonProperty("selectActions")]
        public IList<string>? SelectActions { get; set; }
    }

    public enum ScriptInclude
    {
        selectActions,
        selectHosts,
        selectGroups
    }
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ScriptService : CrudService<Script, ScriptFilterOptions, ScriptService.ScriptResult>
    {


        public ScriptService(ICore core) : base(core, "script")
        {
        }

        

        public class ScriptResult : BaseResult
        {
            [JsonProperty("scriptids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class ScriptFilterOptions : FilterOptions
    {
        [JsonProperty("groupids")]
        public object? GroupIds { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("scriptids")]
        public object? ScriptIds { get; set; }

        [JsonProperty("usrgrpids")]
        public object? UsrgrpIds { get; set; }

        [JsonProperty("selectGroups")]
        public object? SelectGroups { get; set; }

        [JsonProperty("selectHosts")]
        public object? SelectHosts { get; set; }

        [JsonProperty("selectActions")]
        public object? SelectActions { get; set; }
    }

    public enum ScriptInclude
    {
        selectActions,
        selectHosts,
        selectGroups
    }
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ScriptService : CrudService<Script, ScriptFilterOptions, ScriptService.ScriptResult>
    {


        public ScriptService(ICore core) : base(core, "script")
        {
        }

        public ScriptExecuteResult Execute(string scriptId, string? hostId, string? eventId)
        {
            Dictionary<string, string> @params = new() { { "scriptid", scriptId } };
            if(hostId != null)
                @params.Add("hostid", hostId);
            if(eventId != null)
                @params.Add("eventid", eventId);

            return Core.SendRequest<ScriptExecuteResult>(@params, "script.execute");
        }

        public async Task<ScriptExecuteResult> ExecuteAsync(string scriptId, string? hostId, string? eventId)
        {
            Dictionary<string, string> @params = new() { { "scriptid", scriptId } };
            if (hostId != null)
                @params.Add("hostid", hostId);
            if (eventId != null)
                @params.Add("eventid", eventId);

            return await Core.SendRequestAsync<ScriptExecuteResult>(@params, "script.execute");
        }

        public Dictionary<string, IList<Script>> GetScriptsByHosts(IEnumerable<Host> hosts)
        {
            var baseEntities = hosts.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(host => host.EntityId!);

            return Core.SendRequest<Dictionary<string, IList<Script>>>(ids, "script.getscriptsbyhosts");
        }
        public async Task<Dictionary<string, IList<Script>>> GetScriptsByHostsAsync(IEnumerable<Host> hosts)
        {
            var baseEntities = hosts.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(host => host.EntityId!);

            return await Core.SendRequestAsync<Dictionary<string, IList<Script>>>(ids, "script.getscriptsbyhosts");
        }

        public class ScriptResult : BaseResult
        {
            [JsonProperty("scriptids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class ScriptFilterOptions : FilterOptions
    {
        #region Filter Properties

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
        #endregion
    }

    public class ScriptExecuteResult
    {
        [JsonProperty("response")]public string? Response { get; set; }
        [JsonProperty("value")]public string? Value { get; set; }
        [JsonProperty("debug")]public Debug? Debug  { get; set; }
    }

}

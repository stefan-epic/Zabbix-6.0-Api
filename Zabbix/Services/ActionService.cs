using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;
using Action = Zabbix.Entities.Action;

namespace Zabbix.Services;

public class ActionService : CrudService<Action, GetActionFilter, ActionService.ActionResult>
{
    public ActionService(ICore core) : base(core, "action")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class ActionResult : BaseResult
    {
        [JsonProperty("actionids")] public override IList<string>? Ids { get; set; }
    }
  
}
public class GetActionFilter : GetFilter
{
    #region FilterProps

    [JsonProperty("actionids")]
    public IList<string>? ActionIds { get; set; }

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("triggerids")]
    public IList<string>? TriggerIds { get; set; }

    [JsonProperty("mediatypeids")]
    public IList<string>? MediaTypeIds { get; set; }

    [JsonProperty("usrgrpids")]
    public IList<string>? UserGroupIds { get; set; }

    [JsonProperty("userids")]
    public IList<string>? UserIds { get; set; }

    [JsonProperty("scriptids")]
    public IList<string>? ScriptIds { get; set; }

    [JsonProperty("selectFilter")]
    public IList<string>? SelectFilter { get; set; }

    [JsonProperty("selectOperations")]
    public IList<string>? SelectOperations { get; set; }

    [JsonProperty("selectRecoveryOperations")]
    public IList<string>? SelectRecoveryOperations { get; set; }

    [JsonProperty("selectUpdateOperations")]
    public IList<string>? SelectUpdateOperations { get; set; }

    #endregion
}

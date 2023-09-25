using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;
using Action = Zabbix.Entities.Action;

namespace Zabbix.Services;

public class ActionService : CrudService<Action, ActionFilterOptions, ActionService.ActionResult>
{
    public ActionService(ICore core) : base(core, "action")
    {
    }

    public class ActionResult : BaseResult
    {
        [JsonProperty("actionids")] public override IList<string>? Ids { get; set; }
    }
  
}
public class ActionFilterOptions : FilterOptions
{
    #region FilterProps

    [JsonProperty("actionids")]
    public object? ActionIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

    [JsonProperty("mediatypeids")]
    public object? MediaTypeIds { get; set; }

    [JsonProperty("usrgrpids")]
    public object? UserGroupIds { get; set; }

    [JsonProperty("userids")]
    public object? UserIds { get; set; }

    [JsonProperty("scriptids")]
    public object? ScriptIds { get; set; }

    [JsonProperty("selectFilter")]
    public ZabbixQuery? SelectFilter { get; set; }

    [JsonProperty("selectOperations")]
    public ZabbixQuery? SelectOperations { get; set; }

    [JsonProperty("selectRecoveryOperations")]
    public ZabbixQuery? SelectRecoveryOperations { get; set; }

    [JsonProperty("selectUpdateOperations")]
    public ZabbixQuery? SelectUpdateOperations { get; set; }

    #endregion
}

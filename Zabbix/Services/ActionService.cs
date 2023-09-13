﻿using Newtonsoft.Json;
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

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        return BaseBuildParams(filter);
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
    public object? SelectFilter { get; set; }

    [JsonProperty("selectOperations")]
    public object? SelectOperations { get; set; }

    [JsonProperty("selectRecoveryOperations")]
    public object? SelectRecoveryOperations { get; set; }

    [JsonProperty("selectUpdateOperations")]
    public object? SelectUpdateOperations { get; set; }

    #endregion
}

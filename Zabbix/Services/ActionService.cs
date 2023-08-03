using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;
using Action = Zabbix.Entities.Action;

namespace Zabbix.Services;

public class ActionService : CrudService<Action, ActionInclude, ActionProperties, ActionService.ActionResult>
{
    public ActionService(ICore core) : base(core, "action")
    {
    }

    protected override Dictionary<string, object> BuildParams(
        RequestFilter<ActionProperties, ActionInclude> filter = null, Dictionary<string, object> @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class ActionResult : BaseResult
    {
        [JsonProperty("actionids")] public override string[] Ids { get; set; }
    }
}

public enum ActionProperties
{
}

public enum ActionInclude
{
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class TriggerService : CrudService<Trigger, TriggerInclude, TriggerProperties, TriggerService.TriggerResult>
{
    public TriggerService(ICore core) : base(core, "trigger")
    {
    }

    protected override Dictionary<string, object> BuildParams(
        RequestFilter<TriggerProperties, TriggerInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    //TODO: make async variants
    public IList<string> AddDependency(int triggerId, int dependsOnTriggerId)
    {
        Dictionary<string, object>? @params = new Dictionary<string, object>
        {
            { "triggerid", triggerId },
            { "dependsOnTriggerid", dependsOnTriggerId }
        };

        var ret = Core.SendRequest<TriggerResult>(@params, ClassName + ".adddependencies").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public IList<string> DeleteDependency(int triggerId)
    {
        Dictionary<string, object>? @params = new Dictionary<string, object>
        {
            { "triggerid", triggerId }
        };

        var ret = Core.SendRequest<TriggerResult>(@params, ClassName + ".deleteDependencies").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public class TriggerResult : BaseResult
    {
        [JsonProperty("triggerids")] public override IList<string>? Ids { get; set; }
    }
}

public enum TriggerInclude
{
    selectGroups,
    selectHosts,
    selectItems,
    selectFunctions,
    selectDependencies,
    selectDiscoveryRule,
    selectLastEvent,
    selectTags,
    selectTriggerDiscovery
}
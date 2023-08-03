using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class TriggerService : CrudService<Trigger, TriggerInclude, TriggerProperties, TriggerService.TriggerResult>
{
    public TriggerService(ICore core) : base(core, "trigger")
    {
    }

    protected override Dictionary<string, object> BuildParams(
        RequestFilter<TriggerProperties, TriggerInclude> filter = null, Dictionary<string, object> @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    //TODO: make async variants
    public string[] AddDependency(int triggerId, int dependsOnTriggerId)
    {
        Dictionary<string, object> @params = new Dictionary<string, object>
        {
            { "triggerid", triggerId },
            { "dependsOnTriggerid", dependsOnTriggerId }
        };

        return Core.SendRequest<TriggerResult>(@params, ClassName + ".adddependencies").Ids;
    }

    public string[] DeleteDependency(int triggerId)
    {
        Dictionary<string, object> @params = new Dictionary<string, object>
        {
            { "triggerid", triggerId }
        };


        return Core.SendRequest<TriggerResult>(@params, ClassName + ".deleteDependencies").Ids;
    }

    public class TriggerResult : BaseResult
    {
        [JsonProperty("triggerids")] public override string[] Ids { get; set; }
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
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class TriggerService : CrudService<Trigger, GetTriggerFilter, TriggerService.TriggerResult>
{
    public TriggerService(ICore core) : base(core, "trigger")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
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

public class GetTriggerFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("triggerids")]
    public IList<string>? TriggerIds { get; set; }

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("templateids")]
    public IList<string>? TemplateIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("itemids")]
    public IList<string>? ItemIds { get; set; }

    [JsonProperty("functions")]
    public IList<string>? Functions { get; set; }

    [JsonProperty("group")]
    public string? Group { get; set; }

    [JsonProperty("host")]
    public string? Host { get; set; }

    [JsonProperty("inherited")]
    public bool? Inherited { get; set; }

    [JsonProperty("templated")]
    public bool? Templated { get; set; }

    [JsonProperty("dependent")]
    public bool? Dependent { get; set; }

    [JsonProperty("monitored")]
    public bool? Monitored { get; set; }

    [JsonProperty("active")]
    public bool? Active { get; set; }

    [JsonProperty("maintenance")]
    public bool? Maintenance { get; set; }

    [JsonProperty("withUnacknowledgedEvents")]
    public bool? WithUnacknowledgedEvents { get; set; }

    [JsonProperty("withAcknowledgedEvents")]
    public bool? WithAcknowledgedEvents { get; set; }

    [JsonProperty("withLastEventUnacknowledged")]
    public bool? WithLastEventUnacknowledged { get; set; }

    [JsonProperty("skipDependent")]
    public bool? SkipDependent { get; set; }

    [JsonProperty("lastChangeSince")]
    public string? LastChangeSince { get; set; }

    [JsonProperty("lastChangeTill")]
    public string? LastChangeTill { get; set; }

    [JsonProperty("only_true")]
    public bool? OnlyTrue { get; set; }

    [JsonProperty("min_severity")]
    public int? MinSeverity { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("expandComment")]
    public bool? ExpandComment { get; set; }

    [JsonProperty("expandDescription")]
    public bool? ExpandDescription { get; set; }

    [JsonProperty("expandExpression")]
    public bool? ExpandExpression { get; set; }

    [JsonProperty("selectGroups")]
    public IList<string>? SelectGroups { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectItems")]
    public IList<string>? SelectItems { get; set; }

    [JsonProperty("selectFunctions")]
    public IList<string>? SelectFunctions { get; set; }

    [JsonProperty("selectDependencies")]
    public IList<string>? SelectDependencies { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public IList<string>? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectLastEvent")]
    public IList<string>? SelectLastEvent { get; set; }

    [JsonProperty("selectTags")]
    public IList<string>? SelectTags { get; set; }

    [JsonProperty("selectTriggerDiscovery")]
    public IList<string>? SelectTriggerDiscovery { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion
}


using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class TriggerService : CrudService<Trigger, TriggerFilterOptions, TriggerService.TriggerResult>
{
    public TriggerService(ICore core) : base(core, "trigger")
    {
    }

    

    public IEnumerable<string> AddDependency(int triggerId, int dependsOnTriggerId)
    {
        Dictionary<string, object?> @params = new()
        {
            { "triggerid", triggerId },
            { "dependsOnTriggerid", dependsOnTriggerId }
        };

        var ret = Core.SendRequest<TriggerResult>(@params, ClassName + ".adddependencies").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }
    public async Task<IEnumerable<string>> AddDependencyAsync(int triggerId, int dependsOnTriggerId)
    {
        Dictionary<string, object?> @params = new()
        {
            { "triggerid", triggerId },
            { "dependsOnTriggerid", dependsOnTriggerId }
        };

        var ret = (await Core.SendRequestAsync<TriggerResult>(@params, ClassName + ".adddependencies")).Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }
    public IEnumerable<string> DeleteDependency(int triggerId)
    {
        Dictionary<string, object?> @params = new()
        {
            { "triggerid", triggerId }
        };

        var ret = Core.SendRequest<TriggerResult>(@params, ClassName + ".deleteDependencies").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }
    public async Task<IEnumerable<string>> DeleteDependencyAsync(int triggerId)
    {
        Dictionary<string, object?> @params = new()
        {
            { "triggerid", triggerId }
        };

        var ret = (await Core.SendRequestAsync<TriggerResult>(@params, ClassName + ".deleteDependencies")).Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public class TriggerResult : BaseResult
    {
        [JsonProperty("triggerids")] public override IList<string>? Ids { get; set; }
    }
}

public class TriggerFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("triggerids")]
    public object? TriggerIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("templateids")]
    public object? TemplateIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("itemids")]
    public object? ItemIds { get; set; }

    [JsonProperty("functions")]
    public object? Functions { get; set; }

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
    public ZabbixQuery? SelectGroups { get; set; }

    [JsonProperty("selectHosts")]
    public ZabbixQuery? SelectHosts { get; set; }

    [JsonProperty("selectItems")]
    public ZabbixQuery? SelectItems { get; set; }

    [JsonProperty("selectFunctions")]
    public ZabbixQuery? SelectFunctions { get; set; }

    [JsonProperty("selectDependencies")]
    public ZabbixQuery? SelectDependencies { get; set; }

    [JsonProperty("selectDiscoveryRule")]
    public ZabbixQuery? SelectDiscoveryRule { get; set; }

    [JsonProperty("selectLastEvent")]
    public ZabbixQuery? SelectLastEvent { get; set; }

    [JsonProperty("selectTags")]
    public ZabbixQuery? SelectTags { get; set; }

    [JsonProperty("selectTriggerDiscovery")]
    public ZabbixQuery? SelectTriggerDiscovery { get; set; }

    [JsonProperty("limitSelects")]
    public int? LimitSelects { get; set; }

    #endregion
}


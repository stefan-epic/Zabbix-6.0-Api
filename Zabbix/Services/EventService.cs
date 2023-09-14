using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class EventService : GetService<Event, EventFilterOptions>
{
    public EventService(ICore core) : base(core, "event")
    {
    }



    public IEnumerable<string> Acknowledge(IList<string> eventIds, int action, string? message = null, string? severity = null)
    {
        Dictionary<string, object?> @params = new()
        {
            { "eventids", eventIds },
            { "action", action }
        };

        if (message != null)
            @params.Add("message", message);
        if (severity != null)
            @params.Add("severity", severity);

        var ret = Core.SendRequest<EventResult>(@params, ClassName + ".acknowledge").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }
    public async Task<IEnumerable<string>> AcknowledgeAsync(IList<string> eventIds, int action, string? message = null, string? severity = null)
    {
        Dictionary<string, object?> @params = new()
        {
            { "eventids", eventIds },
            { "action", action }
        };

        if (message != null)
            @params.Add("message", message);
        if (severity != null)
            @params.Add("severity", severity);

        var ret = (await Core.SendRequestAsync<EventResult>(@params, ClassName + ".acknowledge")).Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }
    public class EventResult : BaseResult
    {
        public override IList<string>? Ids { get; set; }
    }
}

public class EventFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("eventids")]
    public object? EventIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("objectids")]
    public object? ObjectIds { get; set; }

    [JsonProperty("source")]
    public int? Source { get; set; }

    [JsonProperty("object")]
    public int? Object { get; set; }

    [JsonProperty("acknowledged")]
    public bool? Acknowledged { get; set; }

    [JsonProperty("suppressed")]
    public bool? Suppressed { get; set; }

    [JsonProperty("symptom")]
    public bool? Symptom { get; set; }

    [JsonProperty("severities")]
    public IList<int>? Severities { get; set; }

    [JsonProperty("evaltype")]
    public int? EvaluationType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("eventid_from")]
    public string? EventIdFrom { get; set; }

    [JsonProperty("eventid_till")]
    public string? EventIdTill { get; set; }

    [JsonProperty("time_from")]
    public DateTime? TimeFrom { get; set; }

    [JsonProperty("time_till")]
    public DateTime? TimeTill { get; set; }

    [JsonProperty("problem_time_from")]
    public DateTime? ProblemTimeFrom { get; set; }

    [JsonProperty("problem_time_till")]
    public DateTime? ProblemTimeTill { get; set; }

    [JsonProperty("value")]
    public IList<int>? Values { get; set; }

    [JsonProperty("selectHosts")]
    public object? SelectHosts { get; set; }

    [JsonProperty("selectRelatedObject")]
    public object? SelectRelatedObject { get; set; }

    [JsonProperty("select_alerts")]
    public object? SelectAlerts { get; set; }

    [JsonProperty("select_acknowledges")]
    public object? SelectAcknowledges { get; set; }

    [JsonProperty("selectTags")]
    public object? SelectTags { get; set; }

    [JsonProperty("selectSuppressionData")]
    public object? SelectSuppressionData { get; set; }
    #endregion

}

public class TagFilter
{
    [JsonProperty("tag")]
    public string Tag { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("operator")]
    public int Operator { get; set; }
}
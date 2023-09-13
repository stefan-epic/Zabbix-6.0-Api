using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ProblemService : GetService<Problem, GetProblemFilter>
{
    public ProblemService(ICore core) : base(core, "problem")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter)
    {
        return BaseBuildParams(filter);
    }
}

public class GetProblemFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("eventids")]
    public IList<string>? EventIds { get; set; }

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("objectids")]
    public IList<string>? ObjectIds { get; set; }

    [JsonProperty("source")]
    public int? Source { get; set; }

    [JsonProperty("object")]
    public int? Object { get; set; }

    [JsonProperty("acknowledged")]
    public bool? Acknowledged { get; set; }

    [JsonProperty("suppressed")]
    public bool? Suppressed { get; set; }

    [JsonProperty("severities")]
    public IList<int>? Severities { get; set; }

    [JsonProperty("evaltype")]
    public int? EvalType { get; set; }

    [JsonProperty("tags")]
    public IList<TagFilter>? Tags { get; set; }

    [JsonProperty("recent")]
    public bool? Recent { get; set; }

    [JsonProperty("eventid_from")]
    public string? EventIdFrom { get; set; }

    [JsonProperty("eventid_till")]
    public string? EventIdTill { get; set; }

    [JsonProperty("time_from")]
    public string? TimeFrom { get; set; }

    [JsonProperty("time_till")]
    public string? TimeTill { get; set; }

    [JsonProperty("selectAcknowledges")]
    public IList<string>? SelectAcknowledges { get; set; }

    [JsonProperty("selectTags")]
    public IList<string>? SelectTags { get; set; }

    [JsonProperty("selectSuppressionData")]
    public IList<string>? SelectSuppressionData { get; set; }

    #endregion
}

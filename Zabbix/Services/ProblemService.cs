using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ProblemService : GetService<Problem, ProblemFilterOptions>
{
    public ProblemService(ICore core) : base(core, "problem")
    {
    }

}

public class ProblemFilterOptions : FilterOptions
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
    public ZabbixQuery? SelectAcknowledges { get; set; }

    [JsonProperty("selectTags")]
    public ZabbixQuery? SelectTags { get; set; }

    [JsonProperty("selectSuppressionData")]
    public ZabbixQuery? SelectSuppressionData { get; set; }

    #endregion
}

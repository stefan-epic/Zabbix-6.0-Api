using Newtonsoft.Json;

namespace Zabbix.Entities;

public class Event : BaseEntity
{
    #region Properties

    [JsonProperty("eventid")] public override string? EntityId { get; set; }

    [JsonProperty("source")] public int? Source { get; set; }

    [JsonProperty("object")] public int? EventObject { get; set; }

    [JsonProperty("objectid")] public string? ObjectId { get; set; }

    [JsonProperty("acknowledged")] public int? Acknowledged { get; set; }

    [JsonProperty("clock")] public string? Clock { get; set; }

    [JsonProperty("ns")] public int? Ns { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("value")] public int? Value { get; set; }

    [JsonProperty("severity")] public int? Severity { get; set; }

    [JsonProperty("r_eventid")] public string? REventId { get; set; }

    [JsonProperty("c_eventid")] public string? CEventId { get; set; }

    [JsonProperty("correlationid")] public string? CorrelationId { get; set; }

    [JsonProperty("userid")] public string? UserId { get; set; }

    [JsonProperty("supressed")] public int? Supressed { get; set; }

    [JsonProperty("opdata")] public string? OpData { get; set; }

    #endregion

    #region Components

    [JsonProperty("urls")] public List<MediaType>? Urls { get; set; }

    [JsonProperty("acknowledges")] public List<Acknowledge>? Acknowledges { get; set; }

    [JsonProperty("suppression_data")] public List<SuppressionData>? SuppressionData { get; set; }

    [JsonProperty("tags")] public List<Tag>? Tags { get; set; }

    [JsonProperty("hosts")] private List<Host>? Hosts { get; set; }

    [JsonProperty("relatedObject")] private List<object>? RelatedObjects { get; set; }

    [JsonProperty("alerts")] private List<Alert>? Alerts { get; set; }

    #endregion
}
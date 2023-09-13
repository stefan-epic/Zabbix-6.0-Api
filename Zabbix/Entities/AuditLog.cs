using Newtonsoft.Json;
using Zabbix.Filter;

namespace Zabbix.Entities;

public class AuditLog : BaseEntity
{
    #region Properties

    [JsonProperty("auditid")] public override string? EntityId { get; set; }

    [JsonProperty("userid")] public string? Userid { get; set; }

    [JsonProperty("username")] public string? Username { get; set; }

    [JsonProperty("clock")] public string? Clock { get; set; }

    [JsonProperty("ip")] public string? Ip { get; set; }

    [JsonProperty("action")] public int? Action { get; set; }

    [JsonProperty("resourcetype")] public int? Resourcetype { get; set; }

    [JsonProperty("resourceid")] public string? Resourceid { get; set; }

    [JsonProperty("resourcename")] public string? Resourcename { get; set; }

    [JsonProperty("recordsetid")] public string? Recordsetid { get; set; }

    [JsonProperty("details")] public string? Details { get; set; }

    #endregion
}


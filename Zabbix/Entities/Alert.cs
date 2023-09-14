using Newtonsoft.Json;

namespace Zabbix.Entities;


public class Alert : BaseEntity
{
    #region Properties

    [JsonProperty("alertid")] public override string? EntityId { get; set; }

    [JsonProperty("actionid")] public string? Actionid { get; set; }

    [JsonProperty("eventid")] public string? Eventid { get; set; }

    [JsonProperty("userid")] public string? Userid { get; set; }

    [JsonProperty("clock")] public string? Clock { get; set; }

    [JsonProperty("mediatypeid")] public string? Mediatypeid { get; set; }

    [JsonProperty("sendto")] public string? Sendto { get; set; }

    [JsonProperty("subject")] public string? Subject { get; set; }

    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("retries")] public int? Retries { get; set; }

    [JsonProperty("error")] public string? Error { get; set; }

    [JsonProperty("esc_step")] public int? EscStep { get; set; }

    [JsonProperty("alerttype")] public int? Alerttype { get; set; }

    [JsonProperty("p_eventid")] public string? PEventid { get; set; }

    [JsonProperty("acknowledgeid")] public string? Acknowledgeid { get; set; }

    #endregion

    #region Components

    private List<Host>? Hosts { get; set; }
    private List<MediaType>? MediaTypes { get; set; }
    private List<User>? Users { get; set; }

    #endregion
}


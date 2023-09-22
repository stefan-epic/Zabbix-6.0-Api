using Newtonsoft.Json;

namespace Zabbix.Entities;


public class MediaType : BaseEntity
{
    #region Properties

    [JsonProperty("mediatypeid")]
    public override string? EntityId { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("exec_path")]
    public string? ExecPath { get; set; }

    [JsonProperty("gsm_modem")]
    public string? GsmModem { get; set; }

    [JsonProperty("passwd")]
    public string? Password { get; set; }

    [JsonProperty("smtp_email")]
    public string? SmtpEmail { get; set; }

    [JsonProperty("smtp_helo")]
    public string? SmtpHelo { get; set; }

    [JsonProperty("smtp_server")]
    public string? SmtpServer { get; set; }

    [JsonProperty("smtp_port")]
    public int? SmtpPort { get; set; }

    [JsonProperty("smtp_security")]
    public int? SmtpSecurity { get; set; }

    [JsonProperty("smtp_verify_host")]
    public int? SmtpVerifyHost { get; set; }

    [JsonProperty("smtp_verify_peer")]
    public int? SmtpVerifyPeer { get; set; }

    [JsonProperty("smtp_authentication")]
    public int? SmtpAuthentication { get; set; }

    [JsonProperty("status")]
    public int? Status { get; set; }

    [JsonProperty("username")]
    public string? Username { get; set; }

    [JsonProperty("exec_params")]
    public string? ExecParams { get; set; }

    [JsonProperty("maxsessions")]
    public int? MaxSessions { get; set; }

    [JsonProperty("maxattempts")]
    public int? MaxAttempts { get; set; }

    [JsonProperty("attempt_interval")]
    public string? AttemptInterval { get; set; }

    [JsonProperty("content_type")]
    public int? ContentType { get; set; }

    [JsonProperty("script")]
    public string? Script { get; set; }

    [JsonProperty("timeout")]
    public string? Timeout { get; set; }

    [JsonProperty("process_tags")]
    public int? ProcessTags { get; set; }

    [JsonProperty("show_event_menu")]
    public int? ShowEventMenu { get; set; }

    [JsonProperty("event_menu_url")]
    public string? EventMenuUrl { get; set; }

    [JsonProperty("event_menu_name")]
    public string? EventMenuName { get; set; }

    [JsonProperty("description")]
    public string? Description { get; set; }

    #endregion

    #region Components

    [JsonProperty("parameters")]
    public IList<WebhookParameter>? Parameters { get; set; }

    #endregion

    #region Constructors

    public MediaType(string name, int type)
    {
        Name = name;
        Type = type;
    }
    public MediaType(){}
    
    #endregion
}


public class MessageTemplate
{
    #region Properties

    [JsonProperty("eventsource")]
    public int? EventSource { get; set; }

    [JsonProperty("recovery")]
    public int? Recovery { get; set; }

    [JsonProperty("subject")]
    public string? Subject { get; set; }

    [JsonProperty("message")]
    public string? Message { get; set; }

    #endregion

    #region Constructors

    public MessageTemplate(int eventSource, int recovery)
    {
        EventSource = eventSource;
        Recovery = recovery;
    }

    public MessageTemplate() { }

    #endregion
}
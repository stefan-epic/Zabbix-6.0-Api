using Newtonsoft.Json;

namespace Zabbix.Entities;


public class WebScenario : BaseEntity
{
    #region Components

    [JsonProperty("steps")] public IList<WebScenarioStep>? Steps { get; set; }
    [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }
    [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }

    #endregion

    #region Properties

    [JsonProperty("httptestid")] public override string? EntityId { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("nextcheck")] public string? Nextcheck { get; set; }

    [JsonProperty("delay")] public string? Delay { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("variables")] public IList<object>? Variables { get; set; }

    [JsonProperty("agent")] public string? Agent { get; set; }

    [JsonProperty("authentication")] public int? Authentication { get; set; }

    [JsonProperty("http_user")] public string? HttpUser { get; set; }

    [JsonProperty("http_password")] public string? HttpPassword { get; set; }

    [JsonProperty("hostid")] public string? Hostid { get; set; }

    [JsonProperty("templateid")] public string? Templateid { get; set; }

    [JsonProperty("http_proxy")] public string? HttpProxy { get; set; }

    [JsonProperty("nextcheck")] public string? NextCheck { get; set; }

    [JsonProperty("retries")] public int? Retries { get; set; } = 1;

    [JsonProperty("ssl_cert_file")] public string? SslCertFile { get; set; }

    [JsonProperty("ssl_key_file")] public string? SslKeyFile { get; set; }

    [JsonProperty("ssl_key_password")] public string? SslKeyPassword { get; set; }

    [JsonProperty("verify_peer")] public int? VerifyPeer { get; set; }

    [JsonProperty("verify_host")] public int? VerifyHost { get; set; }

    [JsonProperty("headers")] public IList<object>? Headers { get; set; }

    #endregion

    #region Constructors

    public WebScenario(string name, string? hostid, IList<WebScenarioStep> steps)
    {
        Name = name;
        Hostid = hostid;
        Steps = steps;
    }

    public WebScenario()
    {
    }

    #endregion
}

public class WebScenarioStep
{
    #region Components
    [JsonProperty("variables")] public IList<HttpField>? Variables { get; set; }
    [JsonProperty("posts")] public IList<HttpField>? Posts { get; set; } 
    [JsonProperty("headers")] public IList<HttpField>? Headers { get; set; }
    [JsonProperty("query_fields")] public IList<HttpField>? QueryFields { get; set; }

    #endregion

    #region Properties

    [JsonProperty("httptestid")] public string? WebScenarioId { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("no")] public int? No { get; set; }

    [JsonProperty("url")] public string? Url { get; set; }

    [JsonProperty("timeout")] public string? Timeout { get; set; }

    [JsonProperty("required")] public string? Required { get; set; }

    [JsonProperty("status_codes")] public string? StatusCodes { get; set; }

    [JsonProperty("follow_redirects")] public int? FollowRedirects { get; set; }

    [JsonProperty("retrieve_mode")] public int? RetrieveMode { get; set; }



    #endregion

    #region Constructors

    public WebScenarioStep(string name, int no, string url)
    {
        Name = name;
        No = no;
        Url = url;
    }

    public WebScenarioStep()
    {
    }

    #endregion
}

public class HttpField
{
    #region Properties

    [JsonProperty("name")] public string? Name { get; set; }
    [JsonProperty("value")] public string? Value { get; set; }
    #endregion

    #region Constructors

    public HttpField(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public HttpField() { }

    #endregion

}
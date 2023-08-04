using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum WebScenarioProperties
{
    httptestid,
    name,
    nextcheck,
    delay,
    status,
    variables,
    agent,
    authentication,
    http_user,
    http_password,
    hostid,
    templateid,
    http_proxy,
    retries,
    ssl_cert_file,
    ssl_key_file,
    ssl_key_password,
    verify_peer,
    verify_host
}

public class WebScenario : BaseEntitiy
{
    #region Components

    [JsonProperty("steps")] public List<WebScenarioStep> Steps { get; set; }

    #endregion

    #region Properties

    [JsonProperty("httptestid")] public override string EntityId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("nextcheck")] public string Nextcheck { get; set; }

    [JsonProperty("delay")] public string Delay { get; set; }

    [JsonProperty("status")] public int Status { get; set; }

    [JsonProperty("variables")] public List<object> Variables { get; set; }

    [JsonProperty("agent")] public string Agent { get; set; }

    [JsonProperty("authentication")] public int Authentication { get; set; }

    [JsonProperty("http_user")] public string HttpUser { get; set; }

    [JsonProperty("http_password")] public string HttpPassword { get; set; }

    [JsonProperty("hostid")] public string Hostid { get; set; }

    [JsonProperty("templateid")] public string Templateid { get; set; }

    [JsonProperty("http_proxy")] public string HttpProxy { get; set; }

    [JsonProperty("retries")] public int Retries { get; set; }

    [JsonProperty("ssl_cert_file")] public string SslCertFile { get; set; }

    [JsonProperty("ssl_key_file")] public string SslKeyFile { get; set; }

    [JsonProperty("ssl_key_password")] public string SslKeyPassword { get; set; }

    [JsonProperty("verify_peer")] public int VerifyPeer { get; set; }

    [JsonProperty("verify_host")] public int VerifyHost { get; set; }

    [JsonProperty("headers")] public List<object> Headers { get; set; }

    #endregion

    #region Constructors

    public WebScenario(string name, string hostid, List<WebScenarioStep> steps)
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

public class WebScenarioStep : BaseEntitiy
{
    #region Components

    [JsonProperty("variables")] public List<WebScenarioVariable> Variables { get; set; }

    #endregion

    #region Properties

    [JsonProperty("httptestid")] public override string EntityId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("no")] public int No { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("timeout")] public string Timeout { get; set; }

    [JsonProperty("posts")] public string Posts { get; set; }

    [JsonProperty("required")] public string Required { get; set; }

    [JsonProperty("status_codes")] public string StatusCodes { get; set; }

    [JsonProperty("follow_redirects")] public int FollowRedirects { get; set; }

    [JsonProperty("retrieve_mode")] public int RetrieveMode { get; set; }

    [JsonProperty("headers")] public List<object> Headers { get; set; }

    [JsonProperty("query_fields")] public List<object> QueryFields { get; set; }

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

public class WebScenarioVariable
{
    #region Properties

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("value")] public string Value { get; set; }

    #endregion
}
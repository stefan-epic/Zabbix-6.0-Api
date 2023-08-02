using Newtonsoft.Json;

namespace Zabbix.Entities
{

    public class WebScenario : IBaseEntitiy
    {
        #region Properties
        [JsonProperty("httptestid")]
        public string Httptestid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nextcheck")]
        public string Nextcheck { get; set; }

        [JsonProperty("delay")]
        public string Delay { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("variables")]
        public List<object> Variables { get; set; }

        [JsonProperty("agent")]
        public string Agent { get; set; }

        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        [JsonProperty("http_user")]
        public string HttpUser { get; set; }

        [JsonProperty("http_password")]
        public string HttpPassword { get; set; }

        [JsonProperty("hostid")]
        public string Hostid { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("http_proxy")]
        public string HttpProxy { get; set; }

        [JsonProperty("retries")]
        public string Retries { get; set; }

        [JsonProperty("ssl_cert_file")]
        public string SslCertFile { get; set; }

        [JsonProperty("ssl_key_file")]
        public string SslKeyFile { get; set; }

        [JsonProperty("ssl_key_password")]
        public string SslKeyPassword { get; set; }

        [JsonProperty("verify_peer")]
        public string VerifyPeer { get; set; }

        [JsonProperty("verify_host")]
        public string VerifyHost { get; set; }

        [JsonProperty("headers")]
        public List<object> Headers { get; set; }
        #endregion

        #region Components
        [JsonProperty("steps")]
        public List<WebScenarioStep> Steps { get; set; }
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

    public class WebScenarioStep
    {
        #region Properties
        [JsonProperty("httpstepid")]
        public string Httpstepid { get; set; }

        [JsonProperty("httptestid")]
        public string Httptestid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("no")]
        public string No { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        [JsonProperty("posts")]
        public string Posts { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status_codes")]
        public string StatusCodes { get; set; }

        [JsonProperty("follow_redirects")]
        public string FollowRedirects { get; set; }

        [JsonProperty("retrieve_mode")]
        public string RetrieveMode { get; set; }

        [JsonProperty("headers")]
        public List<object> Headers { get; set; }

        [JsonProperty("query_fields")]
        public List<object> QueryFields { get; set; }
        #endregion

        #region Components
        [JsonProperty("variables")]
        public List<WebScenarioVariable> Variables { get; set; }
        #endregion

        #region Constructors
        public WebScenarioStep(string name, string no, string url)
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
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
}
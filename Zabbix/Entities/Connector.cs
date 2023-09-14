using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class Connector : BaseEntity
    {
        #region Properties

        [JsonProperty("connectorid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("protocol")]
        public int? Protocol { get; set; }

        [JsonProperty("data_type")]
        public int? DataType { get; set; }

        [JsonProperty("max_records")]
        public int? MaxRecords { get; set; }

        [JsonProperty("max_senders")]
        public int? MaxSenders { get; set; }

        [JsonProperty("max_attempts")]
        public int? MaxAttempts { get; set; }

        [JsonProperty("timeout")]
        public string? Timeout { get; set; }

        [JsonProperty("http_proxy")]
        public string? HttpProxy { get; set; }

        [JsonProperty("authtype")]
        public int? AuthType { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("verify_peer")]
        public int? VerifyPeer { get; set; }

        [JsonProperty("verify_host")]
        public int? VerifyHost { get; set; }

        [JsonProperty("ssl_cert_file")]
        public string? SslCertFile { get; set; }

        [JsonProperty("ssl_key_file")]
        public string? SslKeyFile { get; set; }

        [JsonProperty("ssl_key_password")]
        public string? SslKeyPassword { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("tags_evaltype")]
        public int? TagsEvalType { get; set; }
        #endregion

        #region Components

        [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }

        #endregion

        #region Constructors

        public Connector(string name, string url)
        {
            Name = name;
            Url = url;
        }
        public Connector() { }

        #endregion
    }
}

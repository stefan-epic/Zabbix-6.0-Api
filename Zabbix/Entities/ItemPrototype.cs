using Newtonsoft.Json;

namespace Zabbix.Entities
{
    //TODO
    public enum ItemPrototypeProperties
    {

    }
    public class ItemPrototype : BaseEntitiy
    {
        #region Properties

        [JsonProperty("itemid")]
        public override string? EntityId { get; set; }

        [JsonProperty("delay")]
        public string? Delay { get; set; }

        [JsonProperty("hostid")]
        public string? HostId { get; set; }

        [JsonProperty("ruleid")]
        public string? RuleId { get; set; }

        [JsonProperty("interfaceid")]
        public string? InterfaceId { get; set; }

        [JsonProperty("key_")]
        public string? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("value_type")]
        public int? ValueType { get; set; }

        [JsonProperty("allow_traps")]
        public int? AllowTraps { get; set; }

        [JsonProperty("authtype")]
        public int? AuthType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("follow_redirects")]
        public int? FollowRedirects { get; set; }

        [JsonProperty("headers")]
        public object? Headers { get; set; } // You can replace 'object' with an appropriate class if needed.

        [JsonProperty("history")]
        public string? History { get; set; }

        [JsonProperty("http_proxy")]
        public string? HttpProxy { get; set; }

        [JsonProperty("ipmi_sensor")]
        public string? IpmiSensor { get; set; }

        [JsonProperty("jmx_endpoint")]
        public string? JmxEndpoint { get; set; }

        [JsonProperty("logtimefmt")]
        public string? LogTimeFormat { get; set; }

        [JsonProperty("master_itemid")]
        public int? MasterItemId { get; set; }

        [JsonProperty("output_format")]
        public int? OutputFormat { get; set; }

        [JsonProperty("params")]
        public string? Params { get; set; }

        [JsonProperty("parameters")]
        public IList<object>? Parameters { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("post_type")]
        public int? PostType { get; set; }

        [JsonProperty("posts")]
        public string? Posts { get; set; }

        [JsonProperty("privatekey")]
        public string? PrivateKey { get; set; }

        [JsonProperty("publickey")]
        public string? PublicKey { get; set; }

        [JsonProperty("query_fields")]
        public IList<object>? QueryFields { get; set; }// TOdo: maybve change this and the one above

        [JsonProperty("request_method")]
        public int? RequestMethod { get; set; }

        [JsonProperty("retrieve_mode")]
        public int? RetrieveMode { get; set; }

        [JsonProperty("snmp_oid")]
        public string? SnmpOid { get; set; }

        [JsonProperty("ssl_cert_file")]
        public string? SslCertFile { get; set; }

        [JsonProperty("ssl_key_file")]
        public string? SslKeyFile { get; set; }

        [JsonProperty("ssl_key_password")]
        public string? SslKeyPassword { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("status_codes")]
        public string? StatusCodes { get; set; }

        [JsonProperty("templateid")]
        public string? TemplateId { get; private set; }

        [JsonProperty("timeout")]
        public string? Timeout { get; set; }

        [JsonProperty("trapper_hosts")]
        public string? TrapperHosts { get; set; }

        [JsonProperty("trends")]
        public string? Trends { get; set; }

        [JsonProperty("units")]
        public string? Units { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        [JsonProperty("valuemapid")]
        public string? ValueMapId { get; set; }

        [JsonProperty("verify_host")]
        public int? VerifyHost { get; set; }

        [JsonProperty("verify_peer")]
        public int? VerifyPeer { get; set; }

        [JsonProperty("discover")]
        public int? Discover { get; set; }

        #endregion

        #region Components

        [JsonProperty("discoveryRule")] public List<DiscoveryRule>? DiscoveryRules { get; set; }
        [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }
        [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }
        [JsonProperty("triggers")] public IList<Trigger>? Triggers { get; set; }
        [JsonProperty("preprocessing")] public IList<ItemPreprocessing>? Preprocessings { get; set; }
        [JsonProperty("valuemap")] public IList<ValueMap>? ValueMaps { get; set; }
        [JsonProperty("graph_prototype")] public IList<GraphPrototype>? GraphPrototypes { get; set; } //TODO might be wrong check this

        #endregion

    }
    public class ItemPrototypeTag
    {
        #region Properties

        [JsonProperty("tag")]
        public string? Tag { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

    }

    public class ItemPrototypePreprocessing
    {
        #region Properties

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("params")]
        public string? Params { get; set; }

        [JsonProperty("error_handler")]
        public int? ErrorHandler { get; set; }

        [JsonProperty("error_handler_params")]
        public string? ErrorHandlerParams { get; set; }

        #endregion

    }
}

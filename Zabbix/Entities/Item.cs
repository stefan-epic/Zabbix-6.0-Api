using Newtonsoft.Json;

namespace Zabbix.Entities
{

    //TODO
    public class Item : BaseEntitiy
    {
        #region Properties
        [JsonProperty("itemid")]
        public string Itemid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("snmp_oid")]
        public string SnmpOid { get; set; }

        [JsonProperty("hostid")]
        public string Hostid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key_")]
        public string Key { get; set; }

        [JsonProperty("delay")]
        public string Delay { get; set; }

        [JsonProperty("history")]
        public string History { get; set; }

        [JsonProperty("trends")]
        public string Trends { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("value_type")]
        public string ValueType { get; set; }

        [JsonProperty("trapper_hosts")]
        public string TrapperHosts { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("logtimefmt")]
        public string Logtimefmt { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("valuemapid")]
        public string Valuemapid { get; set; }

        [JsonProperty("params")]
        public string Params { get; set; }

        [JsonProperty("ipmi_sensor")]
        public string IpmiSensor { get; set; }

        [JsonProperty("authtype")]
        public string Authtype { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("publickey")]
        public string Publickey { get; set; }

        [JsonProperty("privatekey")]
        public string Privatekey { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("interfaceid")]
        public string Interfaceid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inventory_link")]
        public string InventoryLink { get; set; }

        [JsonProperty("evaltype")]
        public string Evaltype { get; set; }

        [JsonProperty("jmx_endpoint")]
        public string JmxEndpoint { get; set; }

        [JsonProperty("master_itemid")]
        public string MasterItemid { get; set; }

        [JsonProperty("timeout")]
        public string Timeout { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("query_fields")]
        public List<object> QueryFields { get; set; }

        [JsonProperty("posts")]
        public string Posts { get; set; }

        [JsonProperty("status_codes")]
        public string StatusCodes { get; set; }

        [JsonProperty("follow_redirects")]
        public string FollowRedirects { get; set; }

        [JsonProperty("post_type")]
        public string PostType { get; set; }

        [JsonProperty("http_proxy")]
        public string HttpProxy { get; set; }

        [JsonProperty("headers")]
        public List<object> Headers { get; set; }

        [JsonProperty("retrieve_mode")]
        public string RetrieveMode { get; set; }

        [JsonProperty("request_method")]
        public string RequestMethod { get; set; }

        [JsonProperty("output_format")]
        public string OutputFormat { get; set; }

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

        [JsonProperty("allow_traps")]
        public string AllowTraps { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("parameters")]
        public List<object> Parameters { get; set; }

        [JsonProperty("lastclock")]
        public string Lastclock { get; set; }

        [JsonProperty("lastns")]
        public string Lastns { get; set; }

        [JsonProperty("lastvalue")]
        public string Lastvalue { get; set; }

        [JsonProperty("prevvalue")]
        public string Prevvalue { get; set; }
        #endregion
    }
}
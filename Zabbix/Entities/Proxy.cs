using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public class Proxy : BaseEntitiy
    {
        [JsonProperty("proxyid")]
        public override string EntityId { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastaccess")]
        public string LastAccess { get; set; }

        [JsonProperty("tls_connect")]
        public string TlsConnect { get; set; }

        [JsonProperty("tls_accept")]
        public string TlsAccept { get; set; }

        [JsonProperty("tls_issuer")]
        public string TlsIssuer { get; set; }

        [JsonProperty("tls_subject")]
        public string TlsSubject { get; set; }

        [JsonProperty("tls_psk_identity")]
        public string TlsPskIdentity { get; set; }

        [JsonProperty("tls_psk")]
        public string TlsPsk { get; set; }

        [JsonProperty("proxy_address")]
        public string ProxyAddress { get; set; }

        [JsonProperty("auto_compress")]
        public string AutoCompress { get; set; }
    }
}

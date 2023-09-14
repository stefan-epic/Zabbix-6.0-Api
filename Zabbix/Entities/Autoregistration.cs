using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class Autoregistration : BaseEntity
    {
        [JsonProperty("tls_accept")]
        public int? TlsAccept { get; set; }

        [JsonProperty("tls_psk_identity")]
        public string? TlsPskIdentity { get; set; }

        [JsonProperty("tls_psk")]
        public string? TlsPsk { get; set; }
    }


}

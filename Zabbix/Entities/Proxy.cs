using Newtonsoft.Json;

namespace Zabbix.Entities;

//TODO
public enum ProxyProperties
{

}

public class Proxy : BaseEntity
{
    #region Properties

    [JsonProperty("proxyid")] public override string? EntityId { get; set; }

    [JsonProperty("host")] public string? Host { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("lastaccess")] public string? LastAccess { get; set; }

    [JsonProperty("tls_connect")] public int? TlsConnect { get; set; }

    [JsonProperty("tls_accept")] public int? TlsAccept { get; set; }

    [JsonProperty("tls_issuer")] public string? TlsIssuer { get; set; }

    [JsonProperty("tls_subject")] public string? TlsSubject { get; set; }

    [JsonProperty("tls_psk_identity")] public string? TlsPskIdentity { get; set; }

    [JsonProperty("tls_psk")] public string? TlsPsk { get; set; }

    [JsonProperty("proxy_address")] public string? ProxyAddress { get; set; }

    [JsonProperty("auto_compress")] public int? AutoCompress { get; set; }

    #endregion

    #region Components

    [JsonProperty("interface")] public IList<ProxyInterface>? Interfaces { get; set; }
    [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }

    #endregion
}


public class ProxyInterface
{
    #region Properties

    [JsonProperty("dns")]
    public string? Dns { get; set; }

    [JsonProperty("ip")]
    public string? Ip { get; set; }

    [JsonProperty("port")]
    public string? Port { get; set; }

    [JsonProperty("useip")]
    public int? UseIp { get; set; }

    #endregion

}

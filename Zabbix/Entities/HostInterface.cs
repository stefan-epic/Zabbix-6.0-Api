using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum HostInterfaceProperties
{
    interfaceid,
    hostid,
    main,
    type,
    useip,
    ip,
    dns,
    port,
    available,
    error,
    errors_from,
    disable_until
}

//TODO
public class HostDetails
{
    #region Properties

    [JsonProperty("version")]
    public int Version { get; set; }

    [JsonProperty("bulk")]
    public int Bulk { get; set; }

    [JsonProperty("community")]
    public string Community { get; set; }

    [JsonProperty("securityname")]
    public string SecurityName { get; set; }

    [JsonProperty("securitylevel")]
    public int SecurityLevel { get; set; }

    [JsonProperty("authpassphrase")]
    public string AuthPassphrase { get; set; }

    [JsonProperty("privpassphrase")]
    public string PrivPassphrase { get; set; }

    [JsonProperty("authprotocol")]
    public int AuthProtocol { get; set; }

    [JsonProperty("privprotocol")]
    public int PrivProtocol { get; set; }

    [JsonProperty("contextname")]
    public string ContextName { get; set; }

    #endregion
}

public class HostInterface : BaseEntitiy
{
    #region Properties

    [JsonProperty("interfaceid")] public override string EntityId { get; set; }

    [JsonProperty("hostid")] public string Hostid { get; set; }

    [JsonProperty("main")] public int Main { get; set; }

    [JsonProperty("type")] public int Type { get; set; }

    [JsonProperty("useip")] public int Useip { get; set; }

    [JsonProperty("ip")] public string Ip { get; set; }

    [JsonProperty("dns")] public string Dns { get; set; }

    [JsonProperty("port")] public string Port { get; set; }

    [JsonProperty("available")] public int Available { get; set; }

    [JsonProperty("error")] public string Error { get; set; }

    [JsonProperty("errors_from")] public string ErrorsFrom { get; set; }

    [JsonProperty("disable_until")] public string DisableUntil { get; set; }

    #endregion
  
    #region Components

    [JsonProperty("details")] public HostDetails Details { get; set; }
    [JsonProperty("hosts")] public IList<Host> Hosts { get; set; }
    [JsonProperty("items")] public IList<Item> Items { get; set; }

    #endregion

}
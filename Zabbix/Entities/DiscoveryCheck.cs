using Newtonsoft.Json;

namespace Zabbix.Entities;

//TODO
public enum DiscoveryCheckProperties
{

}
public class DiscoveryCheck : BaseEntity
{
    #region Properties

    [JsonProperty("dcheckid")]
    public override string? EntityId { get; set; }

    [JsonProperty("druleid")]
    public string? DRuleId { get; set; }

    [JsonProperty("key_")]
    public string? Key { get; set; }

    [JsonProperty("ports")]
    public string? Ports { get; set; }

    [JsonProperty("snmp_community")]
    public string? SnmpCommunity { get; set; }

    [JsonProperty("snmpv3_authpassphrase")]
    public string? SnmpV3AuthPassphrase { get; set; }

    [JsonProperty("snmpv3_authprotocol")]
    public int? SnmpV3AuthProtocol { get; set; }

    [JsonProperty("snmpv3_contextname")]
    public string? SnmpV3ContextName { get; set; }

    [JsonProperty("snmpv3_privpassphrase")]
    public string? SnmpV3PrivPassphrase { get; set; }

    [JsonProperty("snmpv3_privprotocol")]
    public int? SnmpV3PrivProtocol { get; set; }

    [JsonProperty("snmpv3_securitylevel")]
    public string? SnmpV3SecurityLevel { get; set; }

    [JsonProperty("snmpv3_securityname")]
    public string? SnmpV3SecurityName { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("uniq")]
    public int? Uniq { get; set; }

    [JsonProperty("host_source")]
    public int? HostSource { get; set; }

    [JsonProperty("name_source")]
    public int? NameSource { get; set; }

    #endregion

}
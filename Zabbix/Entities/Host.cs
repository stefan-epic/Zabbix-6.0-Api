using Newtonsoft.Json;

namespace Zabbix.Entities;


public class Host : BaseEntity
{
    #region Properties

    [JsonProperty("hostid")] public override string? EntityId { get; set; }

    [JsonProperty("proxy_hostid")] public string? ProxyHostid { get; set; }

    [JsonProperty("host")] public string? host { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("lastaccess")] public string? Lastaccess { get; set; }

    [JsonProperty("ipmi_authtype")] public int? IpmiAuthtype { get; set; }

    [JsonProperty("ipmi_privilege")] public int? IpmiPrivilege { get; set; }

    [JsonProperty("ipmi_username")] public string? IpmiUsername { get; set; }

    [JsonProperty("ipmi_password")] public string? IpmiPassword { get; set; }

    [JsonProperty("maintenanceid")] public string? Maintenanceid { get; set; }

    [JsonProperty("maintenance_status")] public int? MaintenanceStatus { get; set; }

    [JsonProperty("maintenance_type")] public int? MaintenanceType { get; set; }

    [JsonProperty("maintenance_from")] public string? MaintenanceFrom { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("flags")] public int? Flags { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("tls_connect")] public int? TlsConnect { get; set; }

    [JsonProperty("tls_accept")] public int? TlsAccept { get; set; }

    [JsonProperty("tls_issuer")] public string? TlsIssuer { get; set; }

    [JsonProperty("tls_subject")] public string? TlsSubject { get; set; }

    [JsonProperty("inventory_mode")] public int? InventoryMode { get; set; }

    #endregion

    #region Components

    [JsonProperty("groups")] public IList<HostGroup>? Groups { get; set; }

    [JsonProperty("parentTemplates")] public IList<Template>? Templates { get; set; }

    [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }

    [JsonProperty("triggers")] public IList<Trigger>? Triggers { get; set; }

    [JsonProperty("discoveries")] public IList<LldRule>? LldRules { get; set; }

    [JsonProperty("discoveryRule")] public IList<DiscoveryRule>? DiscoveryRules { get; set; }

    [JsonProperty("hostDiscovery")] public object? HostDiscovery { get; set; } //TODO map this to actual object

    [JsonProperty("items")] public IList<Item>? Items { get; set; }

    [JsonProperty("graphs")] public IList<Graph>? Graphs { get; set; }

    [JsonProperty("httpTests")] public IList<WebScenario>? WebScenarios { get; set; }

    [JsonProperty("interfaces")] public IList<HostInterface>? Interfaces { get; set; }

    [JsonProperty("inventory")] public Inventory? Inventory { get; set; }

    [JsonProperty("macros")] public IList<UserMacro>? Macros { get; set; }

    [JsonProperty("dashboards")] public IList<Dashboard>? Dashboards { get; set; }

    [JsonProperty("inheritedTags")] public IList<Tag>? InheritedTags { get; set; }

    [JsonProperty("valueMaps")] public IList<ValueMap>? ValueMaps { get; set; }

    #endregion

    #region Constructors

    public Host()
    {
    }

    public Host(string hostName, IList<HostGroup> groups)
    {
        host = hostName;
        Groups = groups;
    }
    public Host(string hostName, HostGroup group)
    {
        host = hostName;
        Groups = new List<HostGroup>(){group};
    }

    #endregion
}
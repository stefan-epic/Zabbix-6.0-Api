using Newtonsoft.Json;
using ZabbixApi.Helper;

namespace Zabbix.Entities;

public enum HostProperties
{
    hostid,
    proxy_hostid,
    host,
    status,
    lastaccess,
    ipmi_authtype,
    ipmi_privilege,
    ipmi_username,
    ipmi_password,
    maintenanceid,
    maintenance_status,
    maintenance_type,
    maintenance_from,
    name,
    flags,
    description,
    tls_connect,
    tls_accept,
    tls_issuer,
    tls_subject,
    inventory_mode
}

public class Host : BaseEntitiy
{
    #region Properties

    [JsonProperty("hostid")] public override string? EntityId { get; set; }

    [JsonProperty("proxy_hostid")] public string? ProxyHostid { get; set; }

    [JsonProperty("host")] public string? host { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("lastaccess")] public string? Lastaccess { get; set; }

    [JsonProperty("ipmi_authtype")] public int? IpmiAuthtype { get; set; } = -1;

    [JsonProperty("ipmi_privilege")] public int? IpmiPrivilege { get; set; } = 2;

    [JsonProperty("ipmi_username")] public string? IpmiUsername { get; set; }

    [JsonProperty("ipmi_password")] public string? IpmiPassword { get; set; }

    [JsonProperty("maintenanceid")] public string? Maintenanceid { get; set; }

    [JsonProperty("maintenance_status")] public int? MaintenanceStatus { get; set; }

    [JsonProperty("maintenance_type")] public int? MaintenanceType { get; set; }

    [JsonProperty("maintenance_from")] public string? MaintenanceFrom { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("flags")] public int? Flags { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("tls_connect")] public int? TlsConnect { get; set; } = 1;

    [JsonProperty("tls_accept")] public int? TlsAccept { get; set; } = 1;

    [JsonProperty("tls_issuer")] public string? TlsIssuer { get; set; }

    [JsonProperty("tls_subject")] public string? TlsSubject { get; set; }

    [JsonProperty("inventory_mode")] public int? InventoryMode { get; set; } = -1;

    #endregion

    #region Components

    [JsonProperty("groups")] public IList<HostGroup>? Groups { get; set; }

    [JsonProperty("parentTemplates")] public IList<Template>? Templates { get; set; }

    [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }

    [JsonProperty("triggers")] public IList<Trigger>? Triggers { get; set; }

    //[JsonProperty("discoveries")]
    // not done
    // SelectHostDiscovery
    //public IList<Discovery>? Discoveries { get; set; }

    [JsonProperty("items")] public IList<Item>? Items { get; set; }

    [JsonProperty("graphs")] public IList<Graph>? Graphs { get; set; }

    [JsonProperty("httptests")] public IList<WebScenario>? WebScenarios { get; set; }

    [JsonProperty("interfaces")] public IList<HostInterface>? Interfaces { get; set; }

    [JsonProperty("inventory")] public Inventory? Inventory { get; set; }

    [JsonProperty("macros")] public IList<UserMacro>? Macros { get; set; }

    [JsonProperty("dashboards")] public IList<Dashboard>? Dashboards { get; set; }

    [JsonProperty("inheritedTags")] public IList<Tag>? InheritedTags { get; set; }

    [JsonProperty("valueMaps")] public IList<Tag>? ValueMaps { get; set; }

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

    #endregion
}
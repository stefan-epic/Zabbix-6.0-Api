using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum TemplateProperties
{
    proxy_hostid,
    host,
    status,
    disable_until,
    error,
    available,
    errors_from,
    lastaccess,
    ipmi_authtype,
    ipmi_privilege,
    ipmi_username,
    ipmi_password,
    ipmi_disable_until,
    ipmi_available,
    snmp_disable_until,
    snmp_available,
    maintenanceid,
    maintenance_status,
    maintenance_type,
    maintenance_from,
    ipmi_errors_from,
    snmp_errors_from,
    ipmi_error,
    snmp_error,
    jmx_disable_until,
    jmx_available,
    jmx_errors_from,
    jmx_error,
    name,
    flags,
    templateid,
    description,
    tls_connect,
    tls_accept,
    tls_issuer,
    tls_subject,
    tls_psk_identity,
    tls_psk,
    uuid
}
//TODO

public class Template : BaseEntity
{
    #region Properties

    [JsonProperty("proxy_hostid")] public string? ProxyHostid { get; set; }

    [JsonProperty("host")] public string? Host { get; set; }

    [JsonProperty("status")] public string? Status { get; set; }

    [JsonProperty("disable_until")] public string? DisableUntil { get; set; }

    [JsonProperty("error")] public string? Error { get; set; }

    [JsonProperty("available")] public string? Available { get; set; }

    [JsonProperty("errors_from")] public string? ErrorsFrom { get; set; }

    [JsonProperty("lastaccess")] public string? Lastaccess { get; set; }

    [JsonProperty("ipmi_authtype")] public string? IpmiAuthtype { get; set; }

    [JsonProperty("ipmi_privilege")] public string? IpmiPrivilege { get; set; }

    [JsonProperty("ipmi_username")] public string? IpmiUsername { get; set; }

    [JsonProperty("ipmi_password")] public string? IpmiPassword { get; set; }

    [JsonProperty("ipmi_disable_until")] public string? IpmiDisableUntil { get; set; }

    [JsonProperty("ipmi_available")] public string? IpmiAvailable { get; set; }

    [JsonProperty("snmp_disable_until")] public string? SnmpDisableUntil { get; set; }

    [JsonProperty("snmp_available")] public string? SnmpAvailable { get; set; }

    [JsonProperty("maintenanceid")] public string? Maintenanceid { get; set; }

    [JsonProperty("maintenance_status")] public string? MaintenanceStatus { get; set; }

    [JsonProperty("maintenance_type")] public string? MaintenanceType { get; set; }

    [JsonProperty("maintenance_from")] public string? MaintenanceFrom { get; set; }

    [JsonProperty("ipmi_errors_from")] public string? IpmiErrorsFrom { get; set; }

    [JsonProperty("snmp_errors_from")] public string? SnmpErrorsFrom { get; set; }

    [JsonProperty("ipmi_error")] public string? IpmiError { get; set; }

    [JsonProperty("snmp_error")] public string? SnmpError { get; set; }

    [JsonProperty("jmx_disable_until")] public string? JmxDisableUntil { get; set; }

    [JsonProperty("jmx_available")] public string? JmxAvailable { get; set; }

    [JsonProperty("jmx_errors_from")] public string? JmxErrorsFrom { get; set; }

    [JsonProperty("jmx_error")] public string? JmxError { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("flags")] public string? Flags { get; set; }

    [JsonProperty("templateid")] public override string? EntityId { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("tls_connect")] public string? TlsConnect { get; set; }

    [JsonProperty("tls_accept")] public string? TlsAccept { get; set; }

    [JsonProperty("tls_issuer")] public string? TlsIssuer { get; set; }

    [JsonProperty("tls_subject")] public string? TlsSubject { get; set; }

    [JsonProperty("tls_psk_identity")] public string? TlsPskIdentity { get; set; }

    [JsonProperty("tls_psk")] public string? TlsPsk { get; set; }

    [JsonProperty("uuid")] public string? Uuid { get; set; }

    #endregion
}
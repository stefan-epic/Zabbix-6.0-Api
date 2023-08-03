using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZabbixApi.Helper;

namespace Zabbix.Entities
{
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

        [JsonProperty("hostid")] public override string EntityId { get; set; }

        [JsonProperty("proxy_hostid")] public string ProxyHostid { get; set; }

        [JsonProperty("host")] public string HostName { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("lastaccess")] public string Lastaccess { get; set; }

        [JsonProperty("ipmi_authtype")] public string IpmiAuthtype { get; set; }

        [JsonProperty("ipmi_privilege")] public string IpmiPrivilege { get; set; }

        [JsonProperty("ipmi_username")] public string IpmiUsername { get; set; }

        [JsonProperty("ipmi_password")] public string IpmiPassword { get; set; }

        [JsonProperty("maintenanceid")] public string Maintenanceid { get; set; }

        [JsonProperty("maintenance_status")] public int MaintenanceStatus { get; set; }

        [JsonProperty("maintenance_type")] public string MaintenanceType { get; set; }

        [JsonProperty("maintenance_from")]
        [JsonConverter(typeof(TimestampToDateTimeConverter))]
        public DateTime MaintenanceFrom { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("flags")] public string Flags { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("tls_connect")] public string TlsConnect { get; set; }

        [JsonProperty("tls_accept")] public string TlsAccept { get; set; }

        [JsonProperty("tls_issuer")] public string TlsIssuer { get; set; }

        [JsonProperty("tls_subject")] public string TlsSubject { get; set; }

        [JsonProperty("inventory_mode")] public string InventoryMode { get; set; }

        #endregion

        #region Components

        [JsonProperty("groups")] public IList<HostGroup> Groups { get; set; }

        [JsonProperty("parentTemplates")] public IList<Template> Templates { get; set; }

        [JsonProperty("tags")] public IList<Tag> Tags { get; set; }

        [JsonProperty("triggers")] public IList<Trigger> Triggers { get; set; }

        //[JsonProperty("discoveries")]
        // not done
        // SelectHostDiscovery
        //public IList<Discovery> Discoveries { get; set; }

        [JsonProperty("items")] public IList<Item> Items { get; set; }

        [JsonProperty("graphs")] public IList<Graph> Graphs { get; set; }

        [JsonProperty("httptests")] public IList<WebScenario> WebScenarios { get; set; }

        [JsonProperty("interfaces")] public IList<HostInterface> Interfaces { get; set; }

        [JsonProperty("inventory")] public Inventory Inventory { get; set; }

        [JsonProperty("macros")] public IList<UserMacro> Macros { get; set; }

        [JsonProperty("dashboards")] public IList<Dashboard> Dashboards { get; set; }

        [JsonProperty("inheritedTags")] public IList<Tag> InheritedTags { get; set; }

        [JsonProperty("valueMaps")] public IList<Tag> ValueMaps { get; set; }

        #endregion


        public Host()
        {
        }

        protected new enum Properties
        {
            Property3,
            Property4
        }


        public override string ToString()
        {
            return
                $"{nameof(Hostid)}: {Hostid}, {nameof(ProxyHostid)}: {ProxyHostid}, {nameof(HostName)}: {HostName}, {nameof(Status)}: {Status}, {nameof(Lastaccess)}: {Lastaccess}, {nameof(IpmiAuthtype)}: {IpmiAuthtype}, {nameof(IpmiPrivilege)}: {IpmiPrivilege}, {nameof(IpmiUsername)}: {IpmiUsername}, {nameof(IpmiPassword)}: {IpmiPassword}, {nameof(Maintenanceid)}: {Maintenanceid}, {nameof(MaintenanceStatus)}: {MaintenanceStatus}, {nameof(MaintenanceType)}: {MaintenanceType}, {nameof(MaintenanceFrom)}: {MaintenanceFrom}, {nameof(Name)}: {Name}, {nameof(Flags)}: {Flags}, {nameof(Description)}: {Description}, {nameof(TlsConnect)}: {TlsConnect}, {nameof(TlsAccept)}: {TlsAccept}, {nameof(TlsIssuer)}: {TlsIssuer}, {nameof(TlsSubject)}: {TlsSubject}, {nameof(InventoryMode)}: {InventoryMode}, {nameof(Groups)}: {Groups}, {nameof(Templates)}: {Templates}, {nameof(Tags)}: {Tags}, {nameof(Triggers)}: {Triggers}, {nameof(Items)}: {Items}, {nameof(Graphs)}: {Graphs}, {nameof(WebScenarios)}: {WebScenarios}, {nameof(Interfaces)}: {Interfaces}, {nameof(Inventory)}: {Inventory}, {nameof(Macros)}: {Macros}, {nameof(Dashboards)}: {Dashboards}, {nameof(InheritedTags)}: {InheritedTags}, {nameof(ValueMaps)}: {ValueMaps}";
        }
    }
}
using Newtonsoft.Json;

namespace Zabbix.Entities
{
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

        [JsonProperty("version")] public string Version { get; set; }

        [JsonProperty("bulk")] public string Bulk { get; set; }

        [JsonProperty("community")] public string Community { get; set; }

        #endregion
    }

    public class HostInterface : BaseEntitiy
    {
        #region Properties

        [JsonProperty("interfaceid")] public override string EntityId { get; set; }

        [JsonProperty("hostid")] public string Hostid { get; set; }

        [JsonProperty("main")] public string Main { get; set; }

        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("useip")] public string Useip { get; set; }

        [JsonProperty("ip")] public string Ip { get; set; }

        [JsonProperty("dns")] public string Dns { get; set; }

        [JsonProperty("port")] public string Port { get; set; }

        [JsonProperty("available")] public string Available { get; set; }

        [JsonProperty("error")] public string Error { get; set; }

        [JsonProperty("errors_from")] public string ErrorsFrom { get; set; }

        [JsonProperty("disable_until")] public string DisableUntil { get; set; }

        #endregion

        #region Components

        [JsonProperty("details")] public HostDetails Details { get; set; }

        #endregion
    }
}
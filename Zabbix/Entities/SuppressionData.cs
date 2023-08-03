using Newtonsoft.Json;

namespace Zabbix.Entities;

public class SuppressionData
{
    #region Properties

    [JsonProperty("maintenanceid")] public string Maintenanceid { get; set; }

    [JsonProperty("suppress_until")] public string SuppressUntil { get; set; }

    #endregion
}
using Newtonsoft.Json;

namespace Zabbix.Entities;

//TODO

public enum DiscoveredHostProperties
{

}
public class DiscoveredHost : BaseEntitiy
{
    #region Properties

    [JsonProperty("dhostid")]
    public override string? EntityId { get; set; }

    [JsonProperty("druleid")]
    public string? DRuleId { get; set; }

    [JsonProperty("lastdown")]
    public string? LastDown { get; set; }

    [JsonProperty("lastup")]
    public string? LastUp { get; set; }

    [JsonProperty("status")]
    public int? Status { get; set; }

    #endregion

    #region Components

    [JsonProperty("drules")] public IList<DiscoveryRule>? DiscoveryRules { get; set; }
    [JsonProperty("dservices")] public IList<DiscoveredService>? DiscoveredServices { get; set; }

    #endregion
}
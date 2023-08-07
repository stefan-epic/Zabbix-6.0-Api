using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum DiscoveredServiceProperties
{

}
public class DiscoveredService : BaseEntitiy
{
    #region Properties

    [JsonProperty("dserviceid")]
    public override string? EntityId { get; set; }

    [JsonProperty("dcheckid")]
    public string? DCheckId { get; set; }

    [JsonProperty("dhostid")]
    public string? DHostId { get; set; }

    [JsonProperty("dns")]
    public string? DNS { get; set; }

    [JsonProperty("ip")]
    public string? IP { get; set; }

    [JsonProperty("lastdown")]
    public string? LastDown { get; set; }

    [JsonProperty("lastup")]
    public string? LastUp { get; set; }

    [JsonProperty("port")]
    public int? Port { get; set; }

    [JsonProperty("status")]
    public int? Status { get; set; }

    [JsonProperty("value")]
    public string? Value { get; set; }

    #endregion

    #region Components

    [JsonProperty("drules")]
    public IList<DiscoveryRule>? DiscoveryRules {get; set; }
    [JsonProperty("dhosts")]
    public IList<DiscoveredHost>? DiscoveredHosts {get; set; }
    [JsonProperty("hosts")]
    public IList<Host>? Hosts {get; set; }

    #endregion

}
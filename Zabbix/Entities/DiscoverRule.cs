using Newtonsoft.Json;

namespace Zabbix.Entities;

//TODO
public enum DiscoverRuleProperties
{
}

public class DiscoverRule : BaseEntitiy
{
    #region Properties

    [JsonProperty("druleid")] public override string EntityId { get; set; }

    [JsonProperty("iprange")] public string IpRange { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("delay")] public string Delay { get; set; }

    [JsonProperty("nextcheck")] public string NextCheck { get; set; }

    [JsonProperty("proxy_hostid")] public string ProxyHostId { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    #endregion

    #region Components

    [JsonProperty("dhosts")] public IList<DiscoveredHost> DiscoveredHosts { get; set; }

    [JsonProperty("dchecks")] public IList<DiscoveryCheck> DiscoveredChecks { get; set; }

    #endregion
}
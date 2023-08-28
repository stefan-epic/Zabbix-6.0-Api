using Newtonsoft.Json;

namespace Zabbix.Entities;

public class Tag : BaseEntity
{
    [JsonProperty("tag")] public string? TagName { get; set; }

    [JsonProperty("value")] public string? Value { get; set; }
}
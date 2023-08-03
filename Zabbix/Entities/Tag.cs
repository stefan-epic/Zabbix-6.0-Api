using Newtonsoft.Json;

namespace Zabbix.Entities;

public class Tag : BaseEntitiy
{
    [JsonProperty("tag")] public string TagName { get; set; }

    [JsonProperty("value")] public string Value { get; set; }
}
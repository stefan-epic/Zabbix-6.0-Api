using Newtonsoft.Json;

namespace Zabbix.Core;

internal class Error
{
    [JsonProperty("code")] public long Code { get; set; }

    [JsonProperty("message")] public string Message { get; set; }

    [JsonProperty("data")] public string Data { get; set; }
}
using Newtonsoft.Json;

namespace Zabbix.Core;

internal class Request
{
    public Request()
    {
        JSonRcp = "2.0";
    }

    [JsonProperty("jsonrpc")] public string JSonRcp { get; set; }

    [JsonProperty("method")] public string Method { get; set; } = "";

    [JsonProperty("params")] public object? Params { get; set; }

    [JsonProperty("id")] public string Id { get; set; } = "";

    [JsonProperty("auth")] public string? Auth { get; set; }
}
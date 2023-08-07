using Newtonsoft.Json;

namespace Zabbix.Core;

internal class Response<T>
{
    [JsonProperty("jsonrpc")] public string JSonRcp { get; set; } = "";

    [JsonProperty("result")] public T? Result { get; set; }

    [JsonProperty("error")] public Error? Error { get; set; }

    [JsonProperty("id")] public string Id { get; set; } = string.Empty;
}
using Newtonsoft.Json;

namespace Zabbix.Entities;


//TODO
public class HostPrototype : BaseEntitiy
{
    #region Properties

    [JsonProperty("hostid")]
    public string HostId { get; set; }

    [JsonProperty("host")]
    public string Host { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("iventory_mode")]
    public int InventoryMode { get; set; }

    [JsonProperty("templateid")]
    public string TemplateId { get; set; }

    [JsonProperty("discover")]
    public int Discover { get; set; }

    [JsonProperty("custom_interfaces")]
    public int CustomInterfaces { get; set; }

    [JsonProperty("uuid")]
    public string Uuid { get; set; }

    #endregion

}
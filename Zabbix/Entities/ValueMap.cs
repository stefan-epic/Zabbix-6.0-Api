using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum ValueMapProperties
{

}

public class ValueMappings
{

    #region Properties

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("value")]
    public string? Value { get; set; }

    [JsonProperty("newvalue")]
    public string? NewValue { get; set; }

    #endregion

}

public class ValueMap : BaseEntity
{
    #region Properties

    [JsonProperty("valuemapid")]
    public override string? EntityId { get; set; }

    [JsonProperty("hostid")]
    public string? HostId { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("uuid")]
    public string? UUID { get; set; }

    #endregion

    #region Components

    [JsonProperty("mappings")]
    public IList<ValueMappings>? Mappings { get; set; }

    #endregion
}

//TODO
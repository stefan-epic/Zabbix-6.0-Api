using Newtonsoft.Json;

namespace Zabbix.Entities;

//TODO maybe also make Host and GlobalMacro diffrent classes
public enum UserMacroProperties
{
}

public class UserMacro : BaseEntitiy
{
    #region Properties

    [JsonProperty("hostmacroid")] public override string? EntityId { get; set; }

    [JsonProperty("hostid")] public string? Hostid { get; set; }

    [JsonProperty("macro")] public string? Macro { get; set; }

    [JsonProperty("value")] public string? Value { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("type")] public int? Type { get; set; }

    #endregion

    #region Components

    [JsonProperty("groups")] public IList<HostGroup>? Groups { get; set; }

    [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }

    [JsonProperty("templates")] public IList<Template>? Templates { get; set; }

    #endregion
}
using Newtonsoft.Json;

namespace Zabbix.Entities;

public class UserMacro : BaseEntity
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

    #region Constructors

    public UserMacro(string? hostid, string? macro, string? value)
    {
        Hostid = hostid;
        Macro = macro;
        Value = value;
    }
    public UserMacro() { }

    #endregion
}
public class GlobalMacro : BaseEntity
{
    #region Properties

    [JsonProperty("globalmacroid")] public override string? EntityId { get; set; }

    [JsonProperty("macro")] public string? Macro { get; set; }

    [JsonProperty("value")] public string? Value { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("type")] public int? Type { get; set; }

    #endregion

    #region Components

    [JsonProperty("groups")] public IList<HostGroup>? Groups { get; set; }

    [JsonProperty("templates")] public IList<Template>? Templates { get; set; }

    #endregion

    #region Constructors

    public GlobalMacro(string? macro, string? value)
    {
        Macro = macro;
        Value = value;
    }
    public GlobalMacro() { }

    #endregion
}
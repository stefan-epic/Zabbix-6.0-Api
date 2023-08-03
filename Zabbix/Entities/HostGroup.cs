using Newtonsoft.Json;
using ZabbixApi.Helper;

namespace Zabbix.Entities;

public enum HostGroupProperties
{
    groupid,
    name,
    @internal,
    flags
}
//TODO

public class HostGroup : BaseEntitiy
{
    public override string ToString()
    {
        return $"Group ID: {EntityId}, Name: {Name}, Internal: {Internal}, Flags: {Flags}";
    }

    #region Properties

    [JsonProperty("groupid")] public override string EntityId { get; set; }
    [JsonProperty("name")] public string Name { get; set; }

    [JsonConverter(typeof(IntToBoolConverter))]
    [JsonProperty("internal")]
    public bool Internal { get; set; }

    [JsonProperty("flags")] public string Flags { get; set; }

    #endregion

    #region Components

    //Select discoveryrule
    //select groupdiscovery
    [JsonProperty("hosts")] public IList<Host> Hosts { get; set; }
    [JsonProperty("templates")] public IList<Template> Templates { get; set; }

    #endregion

    #region Constructors

    public HostGroup(string name)
    {
        Name = name;
    }

    public HostGroup()
    {
    }

    #endregion
}
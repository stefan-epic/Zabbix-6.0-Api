using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System;
using Zabbix.Services.CrudServices;

namespace Zabbix.Entities;

public enum HostPrototypeProperties
{

}
//TODO
public class HostPrototype : BaseEntity
{
    #region Properties

    [JsonProperty("hostid")]
    public override string? EntityId { get; set; }

    [JsonProperty("host")]
    public string? Host { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("status")]
    public int? Status { get; set; }

    [JsonProperty("iventory_mode")]
    public int? InventoryMode { get; set; }

    [JsonProperty("templateid")]
    public string? TemplateId { get; set; }

    [JsonProperty("discover")]
    public int? Discover { get; set; }

    [JsonProperty("custom_interfaces")]
    public int? CustomInterfaces { get; set; }

    [JsonProperty("uuid")]
    public string? Uuid { get; set; }

    #endregion

    #region Components
    [JsonProperty("discoveryRule")] public IList<DiscoveryRule>? DiscoveryRules { get; set; }
    [JsonProperty("interfaces")] public IList<CustomInterface>? Interfaces { get; set; }
    [JsonProperty(" groupLinks")] public IList<GroupLink>? GroupLinks { get; set; }
    [JsonProperty("groupPrototypes")] public IList<GroupPrototype>? GroupPrototypes { get; set; }
    [JsonProperty("macros")] public IList<UserMacro>? Macros { get; set; }
    [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }
    [JsonProperty("parentHost")] public IList<Host>? ParentHosts { get; set; }
    [JsonProperty("templates")] public IList<Template>? Templates { get; set; }
    #endregion
}
public class GroupLink
{
    [JsonProperty("groupid")]
    public string? GroupId { get; set; }
}

public class GroupPrototype
{
    [JsonProperty("name")]
    public string? Name { get; set; }
}

public class CustomInterfaceDetails
{
    [JsonProperty("version")]
    public int? Version { get; set; }

    [JsonProperty("bulk")]
    public int? Bulk { get; set; }

    [JsonProperty("community")]
    public string? Community { get; set; }

    [JsonProperty("securityname")]
    public string? SecurityName { get; set; }

    [JsonProperty("securitylevel")]
    public int? SecurityLevel { get; set; }

    [JsonProperty("authpassphrase")]
    public string? AuthPassphrase { get; set; }

    [JsonProperty("privpassphrase")]
    public string? PrivPassphrase { get; set; }

    [JsonProperty("authprotocol")]
    public int? AuthProtocol { get; set; }

    [JsonProperty("privprotocol")]
    public int? PrivProtocol { get; set; }

    [JsonProperty("contextname")]
    public string? ContextName { get; set; }
}

public class CustomInterface
{
    [JsonProperty("dns")]
    public string? DNS { get; set; }

    [JsonProperty("ip")]
    public string? IP { get; set; }

    [JsonProperty("main")]
    public int? Main { get; set; }

    [JsonProperty("port")]
    public string? Port { get; set; }

    [JsonProperty("type")]
    public int? Type { get; set; }

    [JsonProperty("useip")]
    public int? UseIP { get; set; }

    [JsonProperty("details")]
    public CustomInterfaceDetails? Details { get; set; }
}






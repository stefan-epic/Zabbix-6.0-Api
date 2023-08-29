using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum RoleProperties
{
    rules,
    roleid,
    name,
    type,
    @readonly
}

public class Role : BaseEntity
{
    #region Components

    [JsonProperty("rules")] public IList<RoleRule>? Rules { get; set; }

    #endregion

    #region Properties

    [JsonProperty("roleid")] public override string? EntityId { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("type")] public int? type { get; set; }

    [JsonProperty("readonly")] public int? ReadOnly { get; set; }

    #endregion

    #region Constructors

    public Role(string name, int type)
    {
        Name = name;
        this.type = type;
    }

    public Role() { }

    #endregion
}

public class RoleRule
{
    #region Properties

    [JsonProperty("ui.default_access")] public int? UiDefaultAccess { get; set; }

    [JsonProperty("services.read.mode")] public int? ServicesReadMode { get; set; }

    [JsonProperty("services.read.tag")] public IList<Tag>? ServicesReadTag { get; set; }

    [JsonProperty("services.write.mode")] public int? ServicesWriteMode { get; set; }

    [JsonProperty("modules.default_access")]
    public int? ModulesDefaultAccess { get; set; }

    [JsonProperty("api.access")] public int? ApiAccess { get; set; }

    [JsonProperty("api.mode")] public int? ApiMode { get; set; }

    [JsonProperty("api")] public IList<string>? Api { get; set; }

    [JsonProperty("actions.default_access")]
    public int? ActionsDefaultAccess { get; set; }

    #endregion

    #region Components

    [JsonProperty("ui")] public IList<UiElement>? Ui { get; set; }

    [JsonProperty("services.read.list")] public IList<RoleRuleService>? ServicesReadList { get; set; }

    [JsonProperty("services.write.list")] public IList<RoleRuleService>? ServicesWriteList { get; set; }

    [JsonProperty("services.write.tag")] public IList<Tag>? ServicesWriteTag { get; set; }

    [JsonProperty("modules")] public IList<Module>? Modules { get; set; }

    [JsonProperty("actions")] public IList<RoleAction>? Actions { get; set; }

    #endregion

}

public class RoleRuleService
{
    #region Properties

    [JsonProperty("serviceid")] public string? ServiceId { get; set; }

    #endregion

    #region Constructors

    public RoleRuleService(string serviceId)
    {
        ServiceId = serviceId;
    }
    public RoleRuleService() { }

    #endregion
}

public class Module
{
    #region Properties

    [JsonProperty("moduleid")] public string? ModuleId { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    #endregion

    #region Constructors
    public Module(string moduleId)
    {
        ModuleId = moduleId;
    }

    #endregion
}

public class UiElement
{
    #region Properties

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    #endregion

    #region Constructors

    public UiElement(string name)
    {
        Name = name;
    }
    public UiElement() { }

    #endregion
}

public class RoleAction
{
    #region Properties

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    #endregion

    #region Constructors

    public RoleAction(string name)
    {
        Name = name;
    }
    public RoleAction() { }

    #endregion
}
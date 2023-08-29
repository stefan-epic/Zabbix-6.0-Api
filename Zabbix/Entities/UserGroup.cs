using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum UserGroupProperties
{
    usrgrpid,
    name,
    gui_access,
    users_status,
    debug_mode,
    tag_filters,
    users,
    rights
}

public class UserGroup : BaseEntity
{
    #region Properties
    [JsonProperty("usrgrpid")] public override string? EntityId { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("gui_access")] public int? GuiAccess { get; set; }

    [JsonProperty("users_status")] public int? UsersStatus { get; set; }

    [JsonProperty("debug_mode")] public int? DebugMode { get; set; }

    #endregion

    #region Components

    [JsonProperty("tag_filters")] public IList<TagBasedPermission>? Tags { get; set; }
    [JsonProperty("users")] public IList<User>? Users { get; set; }
    [JsonProperty("rights")] public IList<UserGroupPermission>? Rights { get; set; }

    #endregion

    #region Constructors

    public UserGroup(string name)
    {
        Name = name;
    }
    public UserGroup() { }

    #endregion

}

public class UserGroupPermission
{
    #region Properties

    [JsonProperty("id")] public string? Id { get; set; }
    [JsonProperty("permission")] public int? Permission { get; set; }

    #endregion

    #region Constructors

    public UserGroupPermission(string id, int permission)
    {
        Id = id;
        Permission = permission;
    }
    public UserGroupPermission() { }
    #endregion

}
public class TagBasedPermission : Tag
{
    #region Properties

    [JsonProperty("groupid")] public string? GroupId { get; set; }

    #endregion

    #region Constructors

    public TagBasedPermission(string tagName, string value, string groupId) : base(tagName, value)
    {
        GroupId = groupId;
    }
    public TagBasedPermission() { }

    #endregion
}
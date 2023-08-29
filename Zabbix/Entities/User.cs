using Newtonsoft.Json;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/user/login
namespace Zabbix.Entities;

public enum UserProperties
{
    userid,
    username,
    name,
    surname,
    url,
    autologin,
    autologout,
    lang,
    refresh,
    theme,
    attempt_failed,
    attempt_ip,
    attempt_clock,
    rows_per_page,
    timezone,
    roleid,
    type,
    userip,
    debug_mode,
    gui_access,
    sessionid
}
//TODO

public class User : BaseEntity
{
    #region Properties

    [JsonProperty("userid")] public override string? EntityId { get; set; }

    [JsonProperty("username")] public string? Username { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("surname")] public string? Surname { get; set; }

    [JsonProperty("url")] public string? Url { get; set; }

    [JsonProperty("autologin")] public int? Autologin { get; set; }

    [JsonProperty("autologout")] public string? Autologout { get; set; }

    [JsonProperty("lang")] public string? Lang { get; set; }

    [JsonProperty("refresh")] public string? Refresh { get; set; }

    [JsonProperty("theme")] public string? Theme { get; set; }

    [JsonProperty("attempt_failed")] public int? AttemptFailed { get; set; }

    [JsonProperty("attempt_ip")] public string? AttemptIp { get; set; }

    [JsonProperty("attempt_clock")] public string? AttemptClock { get; set; }

    [JsonProperty("rows_per_page")] public int? RowsPerPage { get; set; }

    [JsonProperty("timezone")] public string? Timezone { get; set; }

    [JsonProperty("roleid")] public string? Roleid { get; set; }

    [JsonProperty("passwd")] public string? Passwd { get; set; }

    //for Login UserData
    [JsonProperty("type")] public int? Type { get; set; }

    [JsonProperty("userip")] public string? UserIp { get; set; }

    [JsonProperty("debug_mode")] public int? DebugMode { get; set; }

    [JsonProperty("gui_access")] public int? GuiAccess { get; set; }

    [JsonProperty("users_status")] public int? UserStatus { get; set; }

    //Auth token
    [JsonProperty("sessionid")] public string? SessionId { get; set; }

    #endregion

    #region Components

    [JsonProperty("medias")] public IList<Media>? Medias { get; set; }
    [JsonProperty("mediatypes")] public IList<MediaType>? MediaTypes { get; set; }
    [JsonProperty("usrgrps")] public IList<UserGroup>? UserGroups { get; set; }
    [JsonProperty("role")] public IList<Role>? Roles { get; set; }


    #endregion

    #region Constructor

    public User(string? passwd, IList<UserGroup> groups, string username, string roleid)
    {
        Passwd = passwd;
        UserGroups = groups;
        Username = username;
        Roleid = roleid;
    }
    public User() { }

    #endregion
}


public class Media
{
    #region Properties

    [JsonProperty("mediatypeid")]
    public string? MediaTypeId { get; set; }

    [JsonProperty("sendto")]
    public object? SendTo { get; set; }

    [JsonProperty("active")]
    public int? Active { get; set; }

    [JsonProperty("severity")]
    public int? Severity { get; set; }

    [JsonProperty("period")]
    public string? Period { get; set; }

    #endregion

    #region Constructors

    public Media(string mediaTypeId, object sendTo)
    {
        MediaTypeId = mediaTypeId;
        SendTo = sendTo;
    }
    public Media() { }

    #endregion
}
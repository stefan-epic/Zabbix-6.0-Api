using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum ReportProperties
{
    reportid,
    userid,
    name,
    dashboardid,
    period,
    cycle,
    start_time,
    weekdays,
    active_since,
    active_till,
    subject,
    message,
    status,
    description,
    state,
    lastsent,
    info
}

public class Report : BaseEntitiy
{
    #region Properties

    [JsonProperty("reportid")] public override string? EntityId { get; set; }

    [JsonProperty("userid")] public string? Userid { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("dashboardid")] public string? Dashboardid { get; set; }

    [JsonProperty("period")] public int? Period { get; set; }

    [JsonProperty("cycle")] public int? Cycle { get; set; }

    [JsonProperty("start_time")] public int? StartTime { get; set; }

    [JsonProperty("weekdays")] public int? Weekdays { get; set; }

    [JsonProperty("active_since")] public string? ActiveSince { get; set; }

    [JsonProperty("active_till")] public string? ActiveTill { get; set; }

    [JsonProperty("subject")] public string? Subject { get; set; }

    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("state")] public int? State { get; set; }

    [JsonProperty("lastsent")] public string? Lastsent { get; set; }

    [JsonProperty("info")] public string? Info { get; set; }

    #endregion

    #region Components

    [JsonProperty("users")] public List<ReportUser>? Users { get; set; }

    [JsonProperty("user_groups")] public List<ReportUserGroup>? UserGroups { get; set; }

    #endregion
}

public class ReportUser
{
    #region Properties

    [JsonProperty("userid")] public string? UserId { get; set; }
    [JsonProperty("access_userid")] public string? AccessUserId { get; set; }
    [JsonProperty("exclude")] public int? Exclude { get; set; }

    #endregion

}

public class ReportUserGroup
{
    #region Properties
    [JsonProperty("usrgrpid")] public string? UserGroupId { get; set; }
    [JsonProperty("access_userid")] public string? AccessUserId { get; set; }

    #endregion

}
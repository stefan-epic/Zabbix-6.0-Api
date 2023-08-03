using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
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

        [JsonProperty("reportid")] public override string EntityId { get; set; }

        [JsonProperty("userid")] public string Userid { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("dashboardid")] public string Dashboardid { get; set; }

        [JsonProperty("period")] public string Period { get; set; }

        [JsonProperty("cycle")] public string Cycle { get; set; }

        [JsonProperty("start_time")] public string StartTime { get; set; }

        [JsonProperty("weekdays")] public string Weekdays { get; set; }

        [JsonProperty("active_since")] public string ActiveSince { get; set; }

        [JsonProperty("active_till")] public string ActiveTill { get; set; }

        [JsonProperty("subject")] public string Subject { get; set; }

        [JsonProperty("message")] public string Message { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

        [JsonProperty("state")] public string State { get; set; }

        [JsonProperty("lastsent")] public string Lastsent { get; set; }

        [JsonProperty("info")] public string Info { get; set; }

        #endregion

        #region Components

        [JsonProperty("users")] public List<User> Users { get; set; }

        [JsonProperty("user_groups")] public List<UserGroup> UserGroups { get; set; }

        #endregion
    }
}
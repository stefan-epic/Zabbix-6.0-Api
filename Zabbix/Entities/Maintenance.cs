using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum MaintenanceProperties
    {

    }
    public class Maintenance : BaseEntitiy
    {
        #region Properties
        [JsonProperty("maintenanceid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("active_since")]
        public string? ActiveSince { get; set; }

        [JsonProperty("active_till")]
        public string? ActiveTill { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("maintenance_type")]
        public int? MaintenanceType { get; set; }

        [JsonProperty("tags_evaltype")]
        public int? TagsEvalType { get; set; }

        #endregion

        #region Components

        [JsonProperty("groups")] public IList<HostGroup>? HostGroups { get; set; }
        [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }
        [JsonProperty("tags")] public IList<ProblemTag>? ProblemTags { get; set; }


        #endregion
    }

    public class TimePeriod
    {
        #region Properties

        [JsonProperty("period")]
        public int? Period { get; set; }

        [JsonProperty("timeperiod_type")]
        public int? TimePeriodType { get; set; }

        [JsonProperty("start_date")]
        public string? StartDate { get; set; }

        [JsonProperty("start_time")]
        public int? StartTime { get; set; }

        [JsonProperty("every")]
        public int? Every { get; set; }

        [JsonProperty("dayofweek")]
        public int? DayOfWeek { get; set; }

        [JsonProperty("day")]
        public int? Day { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        #endregion
    }
}

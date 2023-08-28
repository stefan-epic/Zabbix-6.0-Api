using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum SLAProperties
    {

    }
    public class SLA : BaseEntity
    {
        #region Properties

        [JsonProperty("slaid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("period")]
        public int? Period { get; set; }

        [JsonProperty("slo")]
        public float? SLO { get; set; }

        [JsonProperty("effective_date")]
        public long? EffectiveDate { get; set; }

        [JsonProperty("timezone")]
        public string? Timezone { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        #endregion

        #region Components

        [JsonProperty("excluded_downtimes")] public IList<SLAExcludedDowntime>? ExcludedDowntimes { get; set; }
        [JsonProperty("service_tags")] public IList<Tag>? Tags { get; set; }
        [JsonProperty("schedule")] public IList<SLASchedule>? Schedules { get; set; }

        #endregion
    }

    public class SLASchedule
    {
        #region Properties

        [JsonProperty("period_from")]
        public int? PeriodFrom { get; set; }

        [JsonProperty("period_to")]
        public int? PeriodTo { get; set; }


        #endregion

    }

    public class SLAExcludedDowntime
    {
        #region Properties

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("period_from")]
        public long? PeriodFrom { get; set; }

        [JsonProperty("period_to")]
        public long? PeriodTo { get; set; }

        #endregion

    }

    public class SLAServiceTag
    {
        #region Properties

        [JsonProperty("tag")]
        public string? Tag { get; set; }

        [JsonProperty("operator")]
        public int? Operator { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

    }
}

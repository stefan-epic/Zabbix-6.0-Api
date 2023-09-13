using Newtonsoft.Json;

namespace Zabbix.Entities
{
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
        [JsonProperty("service_tags")] public IList<SLAServiceTag>? Tags { get; set; }
        [JsonProperty("schedule")] public IList<SLASchedule>? Schedules { get; set; }

        #endregion

        #region Constructors

        public SLA(string name, int period, float slo, string timezone, IList<SLAServiceTag> tags)
        {
            Name = name;
            Period = period;
            SLO = slo;
            Timezone = timezone;
            Tags = tags;
        }
        public SLA() { }

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

        #region Constructors
        public SLASchedule(int periodFrom, int periodTo)
        {
            PeriodFrom = periodFrom;
            PeriodTo = periodTo;
        }

        public SLASchedule() { }
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

        #region Constructors

        public SLAExcludedDowntime(string name, long periodFrom, long periodTo)
        {
            Name = name;
            PeriodFrom = periodFrom;
            PeriodTo = periodTo;
        }
        #endregion

    }

    public class SLAServiceTag : Tag
    {
        #region Properties

        [JsonProperty("operator")]
        public int? Operator { get; set; }

        #endregion

        #region Constructors
        public SLAServiceTag(string tagName, string value) : base(tagName, value) { }

        #endregion

    }
}

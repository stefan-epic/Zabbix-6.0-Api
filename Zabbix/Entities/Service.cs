using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum ServiceProperties
    {
        serviceid,
        algorithm,
        name,
        sortorder,
        weight,
        propagation_rule,
        propagation_value,
        status,
        description,
        uuid,
        created_at,
        @readonly,
        children,
        parents,
        tags,
        problem_events,
        problem_tags,
        status_rules,
        status_timeline
    }
    public class Service : BaseEntity
    {
        #region Properties

        [JsonProperty("serviceid")]
        public override string? EntityId { get; set; }

        [JsonProperty("algorithm")]
        public int? Algorithm { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("sortorder")]
        public int? SortOrder { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }

        [JsonProperty("propagation_rule")]
        public int? PropagationRule { get; set; }

        [JsonProperty("propagation_value")]
        public int? PropagationValue { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        [JsonProperty("created_at")]
        public int? CreatedAt { get; set; }

        [JsonProperty("readonly")]
        public bool? IsReadOnly { get; set; }
        #endregion

        #region Components

        [JsonProperty("children")] public IList<Service>? Children { get; set; }
        [JsonProperty("parents")] public IList<Service>? Parents { get; set; }
        [JsonProperty("tags")] public IList<Tag>? Tags { get; set; }
        [JsonProperty("problem_events")] public IList<ProblemEvent>? ProblemEvents { get; set; }
        [JsonProperty("problem_tags")] public IList<ProblemTag>? ProblemTags { get; set; }
        [JsonProperty("status_rules")] public IList<StatusRule>? StatusRules { get; set; }
        [JsonProperty("status_timeline")] public IList<object>? StatusTimeline { get; set; } //TODO maybe map this to actual class

        #endregion

        #region Constructors

        public Service(int algorithm, string name, int sortOrder)
        {
            Algorithm = algorithm;
            Name = name;
            SortOrder = sortOrder;
        }

        public Service() { }

        #endregion

    }
    public class StatusRule
    {
        #region Properties

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("limit_value")]
        public int? LimitValue { get; set; }

        [JsonProperty("limit_status")]
        public int? LimitStatus { get; set; }

        [JsonProperty("new_status")]
        public int? NewStatus { get; set; }

        #endregion

        #region Consturctors

        public StatusRule(int type, int limitValue, int limitStatus, int newStatus)
        {
            Type = type;
            LimitValue = limitValue;
            LimitStatus = limitStatus;
            NewStatus = newStatus;
        }

        public StatusRule() { }
        #endregion

    }
    public class ServiceAlarm
    {
        #region Properties

        [JsonProperty("clock")]
        public long? Clock { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }

        #endregion


    }
    public class ProblemTag : Tag
    {
        #region Properties

        [JsonProperty("operator")]
        public int? Operator { get; set; }

        #endregion

        #region Construcors
        public ProblemTag(string tagName, string value) : base(tagName, value) { }
        #endregion

    }


    public class ProblemEvent
    {
        #region Properties

        [JsonProperty("eventid")] public string? EventId { get; set; }
        [JsonProperty("severity")] public string? Severity { get; set; }
        [JsonProperty("name")] public string? Name { get; set; }

        #endregion
    }
}

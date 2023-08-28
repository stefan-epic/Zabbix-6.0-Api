using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum TrendProperties
    {

    }
    public abstract class Trend : BaseEntity
    {
        #region Properties

        [JsonProperty("clock")]
        public string? Timestamp { get; set; }

        [JsonProperty("itemid")]
        public int? ItemId { get; set; }

        [JsonProperty("num")]
        public int? NumValues { get; set; }

        #endregion

    }
    public class FloatTrend : Trend
    {
        #region Properties

        [JsonProperty("value_min")]
        public float? MinValue { get; set; }

        [JsonProperty("value_avg")]
        public float? AverageValue { get; set; }

        [JsonProperty("value_max")]
        public float? MaxValue { get; set; }

        #endregion
    }

    public class IntegerTrend : Trend
    {
        #region Properties

        [JsonProperty("value_min")]
        public int? MinValue { get; set; }

        [JsonProperty("value_avg")]
        public int? AverageValue { get; set; }

        [JsonProperty("value_max")]
        public int? MaxValue { get; set; }

        #endregion
    }
}

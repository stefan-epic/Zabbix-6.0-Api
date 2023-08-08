using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    //TODO ?
    public enum HistoryProperties
    {

    }

    public class History : BaseEntitiy
    {
    }

    public class HistoryBase : History
    {
        [JsonProperty("clock")]
        public long? Clock { get; set; }

        [JsonProperty("itemid")]
        public string? ItemId { get; set; }

        [JsonProperty("ns")]
        public int? Ns { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public class FloatHistory : HistoryBase
    {
        [JsonProperty("value")]
        public float? FloatValue { get; set; }
    }

    public class IntegerHistory : HistoryBase
    {
        [JsonProperty("value")]
        public int? IntegerValue { get; set; }
    }

    public class StringHistory : HistoryBase
    {
        
    }

    public class TextHistory : HistoryBase
    {
        [JsonProperty("id")]
        public override string? EntityId { get; set; }
    }

    public class LogHistory : HistoryBase
    {
        [JsonProperty("id")]
        public override string? EntityId { get; set; }

        [JsonProperty("logeventid")]
        public int? LogEventId { get; set; }

        [JsonProperty("severity")]
        public int? Severity { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }
    }

}

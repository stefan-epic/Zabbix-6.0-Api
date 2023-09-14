using Newtonsoft.Json;

namespace Zabbix.Filter
{
    public class FilterOptions
    {
        [JsonProperty("countOutput")]
        public bool? CountOutput { get; set; }

        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("excludeSearch")]
        public bool? ExcludeSearch { get; set; }

        [JsonProperty("filter")]
        public Dictionary<string, string>? Filter { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("output")]
        public string? Output { get; set; }

        [JsonProperty("preservekeys")]
        public bool? PreserveKeys { get; set; }

        [JsonProperty("search")]
        public Dictionary<string, string>? Search { get; set; }

        [JsonProperty("searchByAny")]
        public bool? SearchByAny { get; set; }

        [JsonProperty("searchWildcardsEnabled")]
        public bool? SearchWildcardsEnabled { get; set; }

        [JsonProperty("sortfield")]
        public IList<string>? SortField { get; set; }

        [JsonProperty("sortorder")]
        public IList<string>? SortOrder { get; set; }

        [JsonProperty("startSearch")]
        public bool? StartSearch { get; set; }

    }
}

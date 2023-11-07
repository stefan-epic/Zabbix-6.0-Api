using Newtonsoft.Json;
using Zabbix.Core;

namespace Zabbix.Filter
{
    public class FilterOptions
    {
        [JsonProperty("editable")]
        public bool? Editable { get; set; }

        [JsonProperty("excludeSearch")]
        public bool? ExcludeSearch { get; set; }

        [JsonProperty("filter")]
        public Dictionary<string, object>? Filter { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("output")]
        public ZabbixQuery? Output { get; set; }

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

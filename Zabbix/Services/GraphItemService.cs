using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class GraphItemService : GetService<GraphItem, GraphItemFilterOptions>
    {
        public GraphItemService(ICore core) : base(core, "graphitem")
        {
        }
    }

    public class GraphItemFilterOptions : FilterOptions
    {
        [JsonProperty("graphids")]
        public object? GraphIds { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("selectGraphs")]
        public ZabbixQuery? SelectGraphs { get; set; }
    }

    public enum GraphItemInclude
    {
        selectGraphs
    }
}

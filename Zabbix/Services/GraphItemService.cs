using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class GraphItemService : GetService<GraphItem, GetGraphItemFilter>
    {
        public GraphItemService(ICore core) : base(core, "graphitem")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class GetGraphItemFilter : GetFilter
    {
        [JsonProperty("graphids")]
        public IList<string>? GraphIds { get; set; }

        [JsonProperty("itemids")]
        public IList<string>? ItemIds { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("selectGraphs")]
        public IList<string>? SelectGraphs { get; set; }
    }

    public enum GraphItemInclude
    {
        selectGraphs
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class GraphService : CrudService<Graph, GraphInclude, GraphProperties, GraphService.GraphResult>
    {
       
        public GraphService(ICore core) : base(core, "graph")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<GraphProperties, GraphInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class GraphResult : BaseResult
        {
            [JsonProperty("graphids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum GraphInclude
    {
        selectGroups,
        selectTemplates,
        selectHosts,
        selectItems,
        selectGraphDiscovery,
        selectGraphItems,
        selectDiscoveryRule
    }
}

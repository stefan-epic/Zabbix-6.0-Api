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
    public class GraphPrototypeService : CrudService<GraphPrototype, GraphPrototypeInclude, GraphItemProperties, GraphPrototypeService.GraphPrototypeResult>
    {
    
        public GraphPrototypeService(ICore core) : base(core, "graphprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<GraphItemProperties, GraphPrototypeInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class GraphPrototypeResult : BaseResult
        {
         [JsonProperty("graphids")] public override IList<string>? Ids { get; set; }
        }

    }

    public enum GraphPrototypeInclude
    {
        selectDiscoveryRule,
        selectGraphItems,
        selectGroups,
        selectHosts,
        selectItems,
        selectTemplates
    }
}

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
    public class GraphService : CrudService<Graph, GetGraphFilter, GraphService.GraphResult>
    {

        public GraphService(ICore core) : base(core, "graph") { }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }

        public class GraphResult : BaseResult
        {
            [JsonProperty("graphids")] public override IList<string>? Ids { get; set; }
        }

    }

    public class GetGraphFilter : GetFilter
    {
        #region Filter Properties

        [JsonProperty("graphids")]
        public IList<string>? GraphIds { get; set; }

        [JsonProperty("groupids")]
        public IList<string>? GroupIds { get; set; }

        [JsonProperty("templateids")]
        public IList<string>? TemplateIds { get; set; }

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("itemids")]
        public IList<string>? ItemIds { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("expandName")]
        public bool? ExpandName { get; set; }

        [JsonProperty("selectHostGroups")]
        public IList<string>? SelectHostGroups { get; set; }

        [JsonProperty("selectTemplateGroups")]
        public IList<string>? SelectTemplateGroups { get; set; }

        [JsonProperty("selectTemplates")]
        public IList<string>? SelectTemplates { get; set; }

        [JsonProperty("selectHosts")]
        public IList<string>? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public IList<string>? SelectItems { get; set; }

        [JsonProperty("selectGraphDiscovery")]
        public IList<string>? SelectGraphDiscovery { get; set; }

        [JsonProperty("selectGraphItems")]
        public IList<string>? SelectGraphItems { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public IList<string>? SelectDiscoveryRule { get; set; }

        #endregion
    }

}

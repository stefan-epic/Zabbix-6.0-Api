using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class GraphService : CrudService<Graph, GraphFilterOptions, GraphService.GraphResult>
    {

        public GraphService(ICore core) : base(core, "graph") { }



        public class GraphResult : BaseResult
        {
            [JsonProperty("graphids")] public override IList<string>? Ids { get; set; }
        }

    }

    public class GraphFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("graphids")]
        public object? GraphIds { get; set; }

        [JsonProperty("groupids")]
        public object? GroupIds { get; set; }

        [JsonProperty("templateids")]
        public object? TemplateIds { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("expandName")]
        public bool? ExpandName { get; set; }

        [JsonProperty("selectHostGroups")]
        public object? SelectHostGroups { get; set; }

        [JsonProperty("selectTemplateGroups")]
        public object? SelectTemplateGroups { get; set; }

        [JsonProperty("selectTemplates")]
        public object? SelectTemplates { get; set; }

        [JsonProperty("selectHosts")]
        public object? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public object? SelectItems { get; set; }

        [JsonProperty("selectGraphDiscovery")]
        public object? SelectGraphDiscovery { get; set; }

        [JsonProperty("selectGraphItems")]
        public object? SelectGraphItems { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public object? SelectDiscoveryRule { get; set; }

        #endregion
    }

}

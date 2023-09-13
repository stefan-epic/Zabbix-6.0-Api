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
    public class GraphPrototypeService : CrudService<GraphPrototype, GraphPrototypeFilterOptions, GraphPrototypeService.GraphPrototypeResult>
    {
    
        public GraphPrototypeService(ICore core) : base(core, "graphprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class GraphPrototypeResult : BaseResult
        {
         [JsonProperty("graphids")] public override IList<string>? Ids { get; set; }
        }

    }

    public class GraphPrototypeFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("discoveryids")]
        public object? DiscoveryIds { get; set; }

        [JsonProperty("graphids")]
        public object? GraphIds { get; set; }

        [JsonProperty("groupids")]
        public object? GroupIds { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("templateids")]
        public object? TemplateIds { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public object? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectGraphItems")]
        public object? SelectGraphItems { get; set; }

        [JsonProperty("selectHostGroups")]
        public object? SelectHostGroups { get; set; }

        [JsonProperty("selectHosts")]
        public object? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public object? SelectItems { get; set; }

        [JsonProperty("selectTemplateGroups")]
        public object? SelectTemplateGroups { get; set; }

        [JsonProperty("selectTemplates")]
        public object? SelectTemplates { get; set; }
        #endregion
    }

}

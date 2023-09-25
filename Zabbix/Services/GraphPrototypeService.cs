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
        public ZabbixQuery? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectGraphItems")]
        public ZabbixQuery? SelectGraphItems { get; set; }

        [JsonProperty("selectHostGroups")]
        public ZabbixQuery? SelectHostGroups { get; set; }

        [JsonProperty("selectHosts")]
        public ZabbixQuery? SelectHosts { get; set; }

        [JsonProperty("selectItems")]
        public ZabbixQuery? SelectItems { get; set; }

        [JsonProperty("selectTemplateGroups")]
        public ZabbixQuery? SelectTemplateGroups { get; set; }

        [JsonProperty("selectTemplates")]
        public ZabbixQuery? SelectTemplates { get; set; }
        #endregion
    }

}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ConnectorService : CrudService<Connector, ConnectorFilterOptions, ConnectorService.ConnectorResult>
    {
        
        public ConnectorService(ICore core) : base(core, "connector") { }
        

        public class ConnectorResult : BaseResult
        {
            [JsonProperty("connectorid")]public override IList<string>? Ids { get; set; }
        }
    }

    public class ConnectorFilterOptions : FilterOptions
    {
        [JsonProperty("connectorids")] public object? ConnectorIds { get; set; }
        [JsonProperty("selectTags")] public ZabbixQuery? SelectTags { get; set; }
    }
}

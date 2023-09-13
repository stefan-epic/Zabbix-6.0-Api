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
    public class ConnectorService : CrudService<Connector, GetConnectorFilter, ConnectorService.ConnectorResult>
    {
        
        public ConnectorService(ICore core, string className) : base(core, className) { }
        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }

        public class ConnectorResult : BaseResult
        {
            [JsonProperty("connectorid")]public override IList<string>? Ids { get; set; }
        }
    }

    public class GetConnectorFilter : GetFilter
    {
        [JsonProperty("connectorids")] public IList<string>? ConnectorIds { get; set; }
        [JsonProperty("selectTags")] public IList<string>? SelectTags { get; set; }
    }
}

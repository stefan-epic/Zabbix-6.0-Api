﻿using System;
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
    public class ConnectorService : CrudService<Connector, ConnectorFilterOptions, ConnectorService.ConnectorResult>
    {
        
        public ConnectorService(ICore core, string className) : base(core, className) { }
        

        public class ConnectorResult : BaseResult
        {
            [JsonProperty("connectorid")]public override IList<string>? Ids { get; set; }
        }
    }

    public class ConnectorFilterOptions : FilterOptions
    {
        [JsonProperty("connectorids")] public object? ConnectorIds { get; set; }
        [JsonProperty("selectTags")] public object? SelectTags { get; set; }
    }
}

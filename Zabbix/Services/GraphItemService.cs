﻿using Newtonsoft.Json;
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
    public class GraphItemService : GetService<GraphItem, GraphItemFilterOptions>
    {
        public GraphItemService(ICore core) : base(core, "graphitem")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class GraphItemFilterOptions : FilterOptions
    {
        [JsonProperty("graphids")]
        public object? GraphIds { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("selectGraphs")]
        public object? SelectGraphs { get; set; }
    }

    public enum GraphItemInclude
    {
        selectGraphs
    }
}

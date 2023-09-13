using Newtonsoft.Json;
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
    //TODO: method clear
    public class HistoryService : GetService<History, HistoryFilterOptions>
    {
        public HistoryService(ICore core) : base(core, "history")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class HistoryFilterOptions : FilterOptions
    {
        [JsonProperty("history")]
        public int? History { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("time_from")]
        public string? TimeFrom { get; set; }

        [JsonProperty("time_till")]
        public string? TimeTill { get; set; }
    }

}

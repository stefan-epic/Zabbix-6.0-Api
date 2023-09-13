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
    public class CorrelationService : CrudService<Correlation, CorrelationFilterOptions, CorrelationService.CorrelationResult>
    {
        

        public CorrelationService(ICore core ) : base(core, "correlation")
        {

        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class CorrelationResult : BaseResult
        {
            [JsonProperty("correlationids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class CorrelationFilterOptions : FilterOptions
    {
        [JsonProperty("correlationids")]
        public object? CorrelationIds { get; set; }

        [JsonProperty("selectFilter")]
        public object? SelectFilter { get; set; }

        [JsonProperty("selectOperations")]
        public object? SelectOperations { get; set; }
    }

}

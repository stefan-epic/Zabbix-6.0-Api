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
    public class CorrelationService : CrudService<Correlation, GetCorrelationFilter, CorrelationService.CorrelationResult>
    {
        

        public CorrelationService(ICore core ) : base(core, "correlation")
        {

        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class CorrelationResult : BaseResult
        {
            [JsonProperty("correlationids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetCorrelationFilter : GetFilter
    {
        [JsonProperty("correlationids")]
        public IList<string>? CorrelationIds { get; set; }

        [JsonProperty("selectFilter")]
        public IList<string>? SelectFilter { get; set; }

        [JsonProperty("selectOperations")]
        public IList<string>? SelectOperations { get; set; }
    }

}

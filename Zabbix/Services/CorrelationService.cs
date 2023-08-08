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
    public class CorrelationService : CrudService<Correlation, CorrelationInclude, CorrelationProperties, CorrelationService.CorrelationResult>
    {
        

        public CorrelationService(ICore core ) : base(core, "correlation")
        {

        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<CorrelationProperties, CorrelationInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class CorrelationResult : BaseResult
        {
            [JsonProperty("correlationids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum CorrelationInclude
    {
        selectFilter,
        selectOperations
    }
}

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
    public class RegexObjectService : CrudService<RegexObject, RegexObjectInclude, RegexObjectProperties, RegexObjectService.RegexObjectResult>
    {

        public RegexObjectService(ICore core) : base(core, "regexp")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<RegexObjectProperties, RegexObjectInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class RegexObjectResult : BaseResult
        {
            [JsonProperty("regexpids")]
            public override string[] Ids { get; set; }
        }

    }

    public enum RegexObjectInclude
    {
    }
}

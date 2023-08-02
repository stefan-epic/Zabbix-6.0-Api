using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Filter.FilterEnums;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TemplateService : CrudService<Template, TemplateInclude, TemplateProperties, TemplateService.TemplateResult>
    {
        public TemplateService(ICore core, string className) : base(core, className)
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<TemplateProperties, TemplateInclude> filter, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class TemplateResult : BaseResult
        {
            [JsonProperty("templateids")]
            public override string[] Ids { get; set; }
        }
    }

    //TODO:
    public enum TemplateInclude
    {
    }
}

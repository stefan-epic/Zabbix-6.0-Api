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
    public class TriggerPrototypeService : CrudService<TriggerPrototype, TriggerPrototypeInclude, TriggerPrototypeProperties, TriggerPrototypeService.TriggerPrototypeResult>
    {

        public TriggerPrototypeService(ICore core) : base(core, "triggerprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<TriggerPrototypeProperties, TriggerPrototypeInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class TriggerPrototypeResult : BaseResult
        {
            [JsonProperty("triggerprototypeids")]
            public override string[] Ids { get; set; }
        }

    }

    public enum TriggerPrototypeInclude
    {
        selectDependencies,
        selectDiscoveryRule,
        selectFunctions,
        selectGroups,
        selectHosts,
        selectItems,
        selectTags
    }
}

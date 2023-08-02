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
    public class TriggerService : CrudService<Trigger, TriggerInclude, TriggerProperties, TriggerService.TriggerResult>
    {
        public TriggerService(ICore core) : base(core, "trigger")
        {
        }

        public class TriggerResult : BaseResult
        {
            [JsonProperty("triggerids")]
            public override string[] Ids { get; set; }
        }

        protected override Dictionary<string, object> BuildParams(
            RequestFilter<TriggerProperties, TriggerInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);

        }
    }

    public enum TriggerInclude
    {
        selectGroups,
        selectHosts,
        selectItems,
        selectFunctions,
        selectDependencies,
        selectDiscoveryRule,
        selectLastEvent,
        selectTags,
        selectTriggerDiscovery

    }
}

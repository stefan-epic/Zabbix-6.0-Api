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
    public class HostPrototypeService : CrudService<HostPrototype, HostPrototypeInclude, HostPrototypeProperties, HostPrototypeService.HostPrototyepResult>
    {

        public HostPrototypeService(ICore core) : base(core, "hostprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<HostPrototypeProperties, HostPrototypeInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
           return BaseBuildParams(filter, @params);
        }
        public class HostPrototyepResult : BaseResult
        {
            [JsonProperty("hostids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum HostPrototypeInclude
    {
        selectDiscoveryRule,
        selectInterfaces,
        selectGroupLinks,
        selectGroupPrototypes,
        selectMacros,
        selectTags,
        selectParentHost,
        selectTemplates
    }
}

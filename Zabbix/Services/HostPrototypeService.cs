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
    public class HostPrototypeService : CrudService<HostPrototype, GetHostPrototypeFilter, HostPrototypeService.HostPrototyepResult>
    {

        public HostPrototypeService(ICore core) : base(core, "hostprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
           return BaseBuildParams(filter);
        }
        public class HostPrototyepResult : BaseResult
        {
            [JsonProperty("hostids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GetHostPrototypeFilter : GetFilter
    {
        #region Filter Properties

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("discoveryids")]
        public IList<string>? DiscoveryIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public IList<string>? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectInterfaces")]
        public IList<string>? SelectInterfaces { get; set; }

        [JsonProperty("selectGroupLinks")]
        public IList<string>? SelectGroupLinks { get; set; }

        [JsonProperty("selectGroupPrototypes")]
        public IList<string>? SelectGroupPrototypes { get; set; }

        [JsonProperty("selectMacros")]
        public IList<string>? SelectMacros { get; set; }

        [JsonProperty("selectParentHost")]
        public IList<string>? SelectParentHost { get; set; }

        [JsonProperty("selectTags")]
        public IList<string>? SelectTags { get; set; }

        [JsonProperty("selectTemplates")]
        public IList<string>? SelectTemplates { get; set; }

        #endregion
    }
}

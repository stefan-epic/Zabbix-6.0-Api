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
    public class HostPrototypeService : CrudService<HostPrototype, HostPrototypeFilterOptions, HostPrototypeService.HostPrototyepResult>
    {

        public HostPrototypeService(ICore core) : base(core, "hostprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
           return BaseBuildParams(filter);
        }
        public class HostPrototyepResult : BaseResult
        {
            [JsonProperty("hostids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class HostPrototypeFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("discoveryids")]
        public object? DiscoveryIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public object? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectInterfaces")]
        public object? SelectInterfaces { get; set; }

        [JsonProperty("selectGroupLinks")]
        public object? SelectGroupLinks { get; set; }

        [JsonProperty("selectGroupPrototypes")]
        public object? SelectGroupPrototypes { get; set; }

        [JsonProperty("selectMacros")]
        public object? SelectMacros { get; set; }

        [JsonProperty("selectParentHost")]
        public object? SelectParentHost { get; set; }

        [JsonProperty("selectTags")]
        public object? SelectTags { get; set; }

        [JsonProperty("selectTemplates")]
        public object? SelectTemplates { get; set; }

        #endregion
    }
}

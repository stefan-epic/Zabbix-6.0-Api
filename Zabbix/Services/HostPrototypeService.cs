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
        public ZabbixQuery? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectInterfaces")]
        public ZabbixQuery? SelectInterfaces { get; set; }

        [JsonProperty("selectGroupLinks")]
        public ZabbixQuery? SelectGroupLinks { get; set; }

        [JsonProperty("selectGroupPrototypes")]
        public ZabbixQuery? SelectGroupPrototypes { get; set; }

        [JsonProperty("selectMacros")]
        public ZabbixQuery? SelectMacros { get; set; }

        [JsonProperty("selectParentHost")]
        public ZabbixQuery? SelectParentHost { get; set; }

        [JsonProperty("selectTags")]
        public ZabbixQuery? SelectTags { get; set; }

        [JsonProperty("selectTemplates")]
        public ZabbixQuery? SelectTemplates { get; set; }

        #endregion
    }
}

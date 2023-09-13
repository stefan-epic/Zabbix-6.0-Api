using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ItemPrototypeService : CrudService<ItemPrototype, GeItemPrototypeFilter, ItemPrototypeService.ItemPrototypeResult>
    {

        public ItemPrototypeService(ICore core) : base(core, "itemprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class ItemPrototypeResult : BaseResult
        {
            [JsonProperty("itemprototypeids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GeItemPrototypeFilter : GetFilter
    {
        #region Filter Properties

        [JsonProperty("discoveryids")]
        public IList<string>? DiscoveryIds { get; set; }

        [JsonProperty("graphids")]
        public IList<string>? GraphIds { get; set; }

        [JsonProperty("hostids")]
        public IList<string>? HostIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("itemids")]
        public IList<string>? ItemIds { get; set; }

        [JsonProperty("monitored")]
        public bool? Monitored { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("templateids")]
        public IList<string>? TemplateIds { get; set; }

        [JsonProperty("triggerids")]
        public IList<string>? TriggerIds { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public IList<string>? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectGraphs")]
        public IList<string>? SelectGraphs { get; set; }

        [JsonProperty("selectHosts")]
        public IList<string>? SelectHosts { get; set; } 

        [JsonProperty("selectTags")]
        public bool? SelectTags { get; set; }

        [JsonProperty("selectTriggers")]
        public IList<string>? SelectTriggers { get; set; } 

        [JsonProperty("selectPreprocessing")]
        public IList<string>? SelectPreprocessing { get; set; }

        [JsonProperty("selectValueMap")]
        public bool? SelectValueMap { get; set; }

        [JsonProperty("limitSelects")]
        public int? LimitSelects { get; set; }

        #endregion
    }

}

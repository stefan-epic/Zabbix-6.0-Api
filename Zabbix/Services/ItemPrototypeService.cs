﻿using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ItemPrototypeService : CrudService<ItemPrototype, GeItemPrototypeFilterOptions, ItemPrototypeService.ItemPrototypeResult>
    {

        public ItemPrototypeService(ICore core) : base(core, "itemprototype")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class ItemPrototypeResult : BaseResult
        {
            [JsonProperty("itemprototypeids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class GeItemPrototypeFilterOptions : FilterOptions
    {
        #region Filter Properties

        [JsonProperty("discoveryids")]
        public object? DiscoveryIds { get; set; }

        [JsonProperty("graphids")]
        public object? GraphIds { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("inherited")]
        public bool? Inherited { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("monitored")]
        public bool? Monitored { get; set; }

        [JsonProperty("templated")]
        public bool? Templated { get; set; }

        [JsonProperty("templateids")]
        public object? TemplateIds { get; set; }

        [JsonProperty("triggerids")]
        public object? TriggerIds { get; set; }

        [JsonProperty("selectDiscoveryRule")]
        public object? SelectDiscoveryRule { get; set; }

        [JsonProperty("selectGraphs")]
        public object? SelectGraphs { get; set; }

        [JsonProperty("selectHosts")]
        public object? SelectHosts { get; set; } 

        [JsonProperty("selectTags")]
        public bool? SelectTags { get; set; }

        [JsonProperty("selectTriggers")]
        public object? SelectTriggers { get; set; } 

        [JsonProperty("selectPreprocessing")]
        public object? SelectPreprocessing { get; set; }

        [JsonProperty("selectValueMap")]
        public bool? SelectValueMap { get; set; }

        [JsonProperty("limitSelects")]
        public int? LimitSelects { get; set; }

        #endregion
    }

}

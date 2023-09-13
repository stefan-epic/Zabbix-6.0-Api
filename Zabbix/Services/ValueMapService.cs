﻿using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ValueMapService : CrudService<ValueMap, ValueFilterOptions, ValueMapService.ValueMapResult>
    {

        public ValueMapService(ICore core) : base(core, "valuemap")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class ValueMapResult : BaseResult
        {
            [JsonProperty("valuemapids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class ValueFilterOptions : FilterOptions
    {
        [JsonProperty("valuemapids")]
        public object? ValueMapIds { get; set; }

        [JsonProperty("selectMappings")]
        public object? SelectMappings { get; set; }
    }

    public enum ValueMapInclude
    {
        selectMappings
    }
}

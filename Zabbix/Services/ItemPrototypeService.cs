using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ItemPrototypeService : CrudService<ItemPrototype, ItemPrototypeInclude, ItemPrototypeProperties, ItemPrototypeService.ItemPrototypeResult>
    {

        public ItemPrototypeService(ICore core, string className) : base(core, className)
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<ItemPrototypeProperties, ItemPrototypeInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class ItemPrototypeResult : BaseResult
        {
            [JsonProperty("itemprototypeids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum ItemPrototypeInclude
    {
    }
}

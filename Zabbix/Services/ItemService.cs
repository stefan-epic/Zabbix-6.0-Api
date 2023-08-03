using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ItemService : CrudService<Item, ItemInclude, ItemProperties, ItemService.ItemResult>
    {
        public class ItemResult : BaseResult
        {
        }

        public ItemService(ICore core, string className) : base(core, className)
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<ItemProperties, ItemInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum ItemInclude
    {
        selectHosts,
        selectInterfaces,
        selectTriggers,
        selectGraphs,
        selectDiscoveryRule,
        selectItemDiscovery,
        selectPreprocessing,
        selectTags,
        selectValueMap
    }
}

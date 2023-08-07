using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ItemService : CrudService<Item, ItemInclude, ItemProperties, ItemService.ItemResult>
{
    public ItemService(ICore core) : base(core, "item")
    {
    }

    protected override Dictionary<string, object>? BuildParams(RequestFilter<ItemProperties, ItemInclude>? filter = null,
        Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class ItemResult : BaseResult
    {
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
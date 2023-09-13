using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ProxyService : CrudService<Proxy, ProxyFilterOptions, ProxyService.ProxyResult>
{

    public ProxyService(ICore core) : base(core, "proxy")
    {
    }

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        return BaseBuildParams(filter);
    }
    public class ProxyResult : BaseResult
    {
        [JsonProperty("proxyids")]
        public override IList<string>? Ids { get; set; }
    }
}

public class ProxyFilterOptions : FilterOptions
{
    [JsonProperty("proxyids")]
    public object? ProxyIds { get; set; }

    [JsonProperty("selectHosts")]
    public object? SelectHosts { get; set; }

    [JsonProperty("selectInterface")]
    public object? SelectInterface { get; set; }
}

public enum ProxyInclude
{
    selectInterface,
    selectHosts
}
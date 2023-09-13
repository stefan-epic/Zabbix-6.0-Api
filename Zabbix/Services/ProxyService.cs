using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ProxyService : CrudService<Proxy, GetProxyFilter, ProxyService.ProxyResult>
{

    public ProxyService(ICore core) : base(core, "proxy")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }
    public class ProxyResult : BaseResult
    {
        [JsonProperty("proxyids")]
        public override IList<string>? Ids { get; set; }
    }
}

public class GetProxyFilter : GetFilter
{
    [JsonProperty("proxyids")]
    public IList<string>? ProxyIds { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectInterface")]
    public IList<string>? SelectInterface { get; set; }
}

public enum ProxyInclude
{
    selectInterface,
    selectHosts
}
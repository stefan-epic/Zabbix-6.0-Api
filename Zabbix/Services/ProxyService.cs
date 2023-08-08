using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ProxyService : CrudService<Proxy, ProxyInclude, ProxyProperties, ProxyService.ProxyResult>
{

    public ProxyService(ICore core) : base(core, "proxy")
    {
    }

    protected override Dictionary<string, object>? BuildParams(RequestFilter<ProxyProperties, ProxyInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }
    public class ProxyResult : BaseResult
    {
        [JsonProperty("proxyids")]
        public override IList<string>? Ids { get; set; }
    }
}

public enum ProxyInclude
{
    selectInterface,
    selectHosts
}
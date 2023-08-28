using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class HostGroupService : MassCrudService<HostGroup, HostGroupInclude, HostGroupProperties,
    HostGroupService.HostGroupResult>
{
    public HostGroupService(ICore core) : base(core, "hostgroup")
    {
    }

    protected override Dictionary<string, object> BuildParams(
        RequestFilter<HostGroupProperties, HostGroupInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class HostGroupResult : BaseResult
    {
        [JsonProperty("hostgroupids")] public override IList<string>? Ids { get; set; }
    }
    /*
    public override Dictionary<string, object> BuildMassParams(IEnumerable<HostGroup> entities, HostGroup properties, Dictionary<string, object>? @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, object>();

        var hostIds = entities.ToList().Select(host => host.EntityId).ToList();
        @params.Add("groups", hostIds);

        JsonSerializerSettings settings = new()
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        @params.Add("params", JsonConvert.SerializeObject(properties, settings));

        return @params;
    }
    */

    public override Dictionary<string, object> BuildMassParams(IEnumerable<HostGroup> entities, Dictionary<HostGroupProperties, object> properties, Dictionary<string, object>? @params = null)
    {
        throw new NotImplementedException();
    }
}

public enum HostGroupInclude
{
    selectDiscoveryRule,
    selectGroupDiscovery,
    selectHosts,
    selectTemplates
}
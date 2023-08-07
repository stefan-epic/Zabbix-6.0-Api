using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class RoleService : CrudService<Role, RoleInclude, RoleProperties, RoleService.RoleResult>
{
    public RoleService(ICore core) : base(core, "role")
    {
    }

    protected override Dictionary<string, object>? BuildParams(RequestFilter<RoleProperties, RoleInclude>? filter = null,
        Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class RoleResult : BaseResult
    {
        [JsonProperty("roleids")] public override IList<string>? Ids { get; set; }
    }
}

public enum RoleInclude
{
    selectUsers,
    selectRules
}
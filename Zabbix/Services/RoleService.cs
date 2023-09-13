using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class RoleService : CrudService<Role, GetRoleFilter, RoleService.RoleResult>
{
    public RoleService(ICore core) : base(core, "role")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class RoleResult : BaseResult
    {
        [JsonProperty("roleids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetRoleFilter : GetFilter
{
    [JsonProperty("roleids")]
    public IList<string>? RoleIds { get; set; }

    [JsonProperty("selectRules")]
    public IList<string>? SelectRules { get; set; }

    [JsonProperty("selectUsers")]
    public IList<string>? SelectUsers { get; set; }
}

public enum RoleInclude
{
    selectUsers,
    selectRules
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class RoleService : CrudService<Role, RoleFilterOptions, RoleService.RoleResult>
{
    public RoleService(ICore core) : base(core, "role")
    {
    }

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class RoleResult : BaseResult
    {
        [JsonProperty("roleids")] public override IList<string>? Ids { get; set; }
    }
}

public class RoleFilterOptions : FilterOptions
{
    [JsonProperty("roleids")]
    public object? RoleIds { get; set; }

    [JsonProperty("selectRules")]
    public object? SelectRules { get; set; }

    [JsonProperty("selectUsers")]
    public object? SelectUsers { get; set; }
}

public enum RoleInclude
{
    selectUsers,
    selectRules
}
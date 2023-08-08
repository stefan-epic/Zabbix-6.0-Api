using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/usermacro/get
//TODO: Global functions
public class UserMacroService : CrudService<UserMacro, UserMacroInclude, UserMacroProperties,
    UserMacroService.UserMacroResult>
{
    public UserMacroService(ICore core) : base(core, "usermacro")
    {
    }

    protected override Dictionary<string, object> BuildParams(
        RequestFilter<UserMacroProperties, UserMacroInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class UserMacroResult : BaseResult
    {
        [JsonProperty("hostmacroids")] public override IList<string>? Ids { get; set; }
    }
}

public enum UserMacroInclude
{
    selectGroups,
    selectHosts,
    selectTemplates
}
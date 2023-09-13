using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/usermacro/get
//TODO: Global functions
public class UserMacroService : CrudService<UserMacro, GetUserMacroFilter, UserMacroService.UserMacroResult>
{
    public UserMacroService(ICore core) : base(core, "usermacro")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    public class UserMacroResult : BaseResult
    {
        [JsonProperty("hostmacroids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetUserMacroFilter : GetFilter
{
    [JsonProperty("globalmacro")] public bool? GlobalMacro { get; set; }

    [JsonProperty("globalmacroids")] public IList<string>? GlobalMacroIds { get; set; }

    [JsonProperty("groupids")] public IList<string>? GroupIds { get; set; }

    [JsonProperty("hostids")] public IList<string>? HostIds { get; set; }

    [JsonProperty("hostmacroids")] public IList<string>? HostMacroIds { get; set; }

    [JsonProperty("inherited")] public bool? Inherited { get; set; }

    [JsonProperty("selectGroups")] public IList<string>? SelectGroups { get; set; }

    [JsonProperty("selectHosts")] public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectTemplates")] public IList<string>? SelectTemplates { get; set; }
}
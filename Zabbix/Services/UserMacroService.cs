using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/usermacro/get
//TODO: Global functions
public class UserMacroService : CrudService<UserMacro, UserMacroFilterOptions, UserMacroService.UserMacroResult>
{
    public UserMacroService(ICore core) : base(core, "usermacro")
    {
    }


    public class UserMacroResult : BaseResult
    {
        [JsonProperty("hostmacroids")] public override IList<string>? Ids { get; set; }
    }
}

public class UserMacroFilterOptions : FilterOptions
{
    [JsonProperty("globalmacro")] public bool? GlobalMacro { get; set; }

    [JsonProperty("globalmacroids")] public object? GlobalMacroIds { get; set; }

    [JsonProperty("groupids")] public object? GroupIds { get; set; }

    [JsonProperty("hostids")] public object? HostIds { get; set; }

    [JsonProperty("hostmacroids")] public object? HostMacroIds { get; set; }

    [JsonProperty("inherited")] public bool? Inherited { get; set; }

    [JsonProperty("selectGroups")] public object? SelectGroups { get; set; }

    [JsonProperty("selectHosts")] public object? SelectHosts { get; set; }

    [JsonProperty("selectTemplates")] public object? SelectTemplates { get; set; }
}
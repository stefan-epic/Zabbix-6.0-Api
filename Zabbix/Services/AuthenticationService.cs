using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//TOdo: cannot implement IGetService or Update
public class AuthenticationService : ServiceBase
{
    private class AuthenticationResult : BaseResult
    {
        [JsonIgnore] public override IList<string>? Ids { get; set; }
    }

    public AuthenticationService(ICore core) : base(core, "authentication")
    {
    }

    #region Get

    public Authentication Get(AuthenticationFilterOptions? filter = null)
    {
        return Core.SendRequest<Authentication>(BuildParams(filter), ClassName + ".get");
    }
    public async Task<Authentication> GetAsync(AuthenticationFilterOptions? filter = null)
    {
        return await Core.SendRequestAsync<Authentication>(BuildParams(filter), ClassName + ".get");
    }

    #endregion

    #region Update

    public IEnumerable<string> Update(Authentication entity)
    {
        var ret = Core.SendRequest<IEnumerable<string>>(entity, ClassName + ".update");
        return ret;
    }

    public async Task<IEnumerable<string>> UpdateAsync(Authentication entity)
    {
        var ret = await Core.SendRequestAsync<IEnumerable<string>>(entity, ClassName + ".update");
        return ret;
    }

    #endregion

}

public class AuthenticationFilterOptions : FilterOptions
{
    //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
}
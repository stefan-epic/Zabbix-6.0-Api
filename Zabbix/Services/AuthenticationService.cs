using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class AuthenticationService : ServiceBase, IGetService<Authentication, AuthenticationFilterOptions>, IUpdateService<Authentication, IEnumerable<string>>
{
    private class AuthenticationResult : BaseResult
    {
        [JsonIgnore] public override IList<string>? Ids { get; set; }
    }

    private GetService<Authentication, AuthenticationFilterOptions> _getService;
    public AuthenticationService(ICore core) : base(core, "authentication")
    {
        _getService = new(core, "authentication");
    }

    #region Get

    public virtual IEnumerable<Authentication> Get(AuthenticationFilterOptions? filter = null)
    {
        return _getService.Get(filter);
    }

    public async Task<IEnumerable<Authentication>> GetAsync(AuthenticationFilterOptions? filter = null)
    {
        return await _getService.GetAsync(filter);
    }

    #endregion

    #region Update

    public virtual IEnumerable<IEnumerable<string>> Update(IEnumerable<Authentication> entities)
    {
        var ret = Core.SendRequest<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update");
        return ret;
    }

    public virtual IEnumerable<string> Update(Authentication entity)
    {
        var ret = Update(new List<Authentication> { entity }).FirstOrDefault();
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public virtual async Task<IEnumerable<IEnumerable<string>>> UpdateAsync(IEnumerable<Authentication> entities)
    {
        var ret = (await Core.SendRequestAsync<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update"));
        return ret;
    }

    public virtual async Task<IEnumerable<string>> UpdateAsync(Authentication entity)
    {
        var ret = (await UpdateAsync(new List<Authentication> { entity })).FirstOrDefault();
        return Checker.ReturnEmptyListOrActual(ret);
    }


    #endregion

}

public class AuthenticationFilterOptions : FilterOptions
{
    //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
}
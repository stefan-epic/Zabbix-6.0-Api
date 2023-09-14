using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//TODO:
public class AuthenticationService
{
    private class AuthenticationResult : BaseResult
    {
        [JsonIgnore] public override IList<string>? Ids { get; set; }
        public IList<string> updatedParams { get; set; }
    }

    private GetService<Authentication, AuthenticationFilterOptions> _getService;
    private UpdateService<Authentication, AuthenticationService.AuthenticationResult> _updateService;
    public AuthenticationService(ICore core)
    {
        _getService = new(core, "authentication");
        _updateService = new(core, "authentication");
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

}

public class AuthenticationFilterOptions : FilterOptions
{
    //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
}
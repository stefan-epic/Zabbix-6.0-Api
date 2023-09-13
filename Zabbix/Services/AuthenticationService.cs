using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//TODO:
public class AuthenticationService : GetAndUpdateService<Authentication, AuthenticationFilterOptions, bool>
{
    public AuthenticationService(ICore core) : base(core, "authentication")
    {
    }

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        return BaseBuildParams(filter);
    }
}

public class AuthenticationFilterOptions : FilterOptions
{
    //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
}
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

//TODO:
public class AuthenticationService : GetAndUpdateService<Authentication, GetAuthenticationFilter, bool>
{
    public AuthenticationService(ICore core) : base(core, "authentication")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }
}

public class GetAuthenticationFilter : GetFilter
{
    //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
}
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;


//TODO:
public class AuthenticationService : GetAndUpdateService<Authentication, AuthenticationInclude, AuthenticationProperties>
{
    public AuthenticationService(ICore core) : base(core, "authentication")
    {
    }

    protected override Dictionary<string, object> BuildParams(RequestFilter<AuthenticationProperties, AuthenticationInclude> filter = null, Dictionary<string, object> @params = null)
    {
        return BaseBuildParams(filter, @params);
    }
}

public enum AuthenticationInclude
{
}
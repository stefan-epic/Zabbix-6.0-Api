using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class UserService : CrudService<User, UserInclude, UserProperties, UserService.UserResult>
{
    public UserService(ICore core) : base(core, "user")
    {
    }

    protected override Dictionary<string, object>? BuildParams(
        RequestFilter<UserProperties, UserInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    //TODO Make Async Variants
    public User Login(string username, string password, Dictionary<string, string>? @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, string>
                { { "username", username }, { "password", password }, { "userData", "true" } };
        return Core.SendRequest<User>(@params, ClassName + ".login", null);
    }

    public void Logout()
    {
    }

    public class UserResult : BaseResult
    {
        [JsonProperty("userids")] public override IList<string>? Ids { get; set; }
    }
}

public enum UserInclude
{
    selectMedias,
    selectMediatypes,
    selectUsrgrps,
    selectRole
}
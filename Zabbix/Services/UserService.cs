using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class UserService : CrudService<User, UserFilter, UserService.UserResult>
{
    public UserService(ICore core) : base(core, "user")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }

    //TODO Make Async Variants
    public User Login(string username, string password, Dictionary<string, string>? @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, string>
                { { "username", username }, { "password", password }, { "userData", "true" } };
        return Core.SendRequest<User>(@params, ClassName + ".login", null);
    }

    public bool Logout()
    {
        var res =  Core.SendRequest<bool>(new Dictionary<string, string>(), ClassName + ".logout", null);
        return res;
    }

    public async Task<User> LoginAsync(string username, string password, Dictionary<string, string>? @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, string>
                { { "username", username }, { "password", password }, { "userData", "true" } };
        return await Core.SendRequestAsync<User>(@params, ClassName + ".login", null);
    }

    public async Task<bool> LogoutAsync()
    {
        var res = await Core.SendRequestAsync<bool>(new Dictionary<string, string>(), ClassName + ".logout", null);
        return res;
    }

    public class UserResult : BaseResult
    {
        [JsonProperty("userids")] public override IList<string>? Ids { get; set; }
    }
}

public class UserFilter : GetFilter
{
    [JsonProperty("mediaids")]
    public IList<string>? MediaIds { get; set; }

    [JsonProperty("mediatypeids")]
    public IList<string>? MediaTypeIds { get; set; }

    [JsonProperty("userids")]
    public IList<string>? UserIds { get; set; }

    [JsonProperty("usrgrpids")]
    public IList<string>? UserGroupIds { get; set; }

    [JsonProperty("getAccess")]
    public bool? GetAccess { get; set; }

    [JsonProperty("selectMedias")]
    public IList<string>? SelectMedias { get; set; }

    [JsonProperty("selectMediatypes")]
    public IList<string>? SelectMediatypes { get; set; }

    [JsonProperty("selectUsrgrps")]
    public IList<string>? SelectUsrgrps { get; set; }

    [JsonProperty("selectRole")]
    public bool? SelectRole { get; set; }
}

public enum UserInclude
{
    selectMedias,
    selectMediatypes,
    selectUsrgrps,
    selectRole
}
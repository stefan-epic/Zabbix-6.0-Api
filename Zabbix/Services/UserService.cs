using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class UserService : CrudService<User, UserFilterOptions, UserService.UserResult>
{
    public UserService(ICore core) : base(core, "user")
    {
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

public class UserFilterOptions : FilterOptions
{
    [JsonProperty("mediaids")]
    public object? MediaIds { get; set; }

    [JsonProperty("mediatypeids")]
    public object? MediaTypeIds { get; set; }

    [JsonProperty("userids")]
    public object? UserIds { get; set; }

    [JsonProperty("usrgrpids")]
    public object? UserGroupIds { get; set; }

    [JsonProperty("getAccess")]
    public bool? GetAccess { get; set; }

    [JsonProperty("selectMedias")]
    public object? SelectMedias { get; set; }

    [JsonProperty("selectMediatypes")]
    public object? SelectMediatypes { get; set; }

    [JsonProperty("selectUsrgrps")]
    public object? SelectUsrgrps { get; set; }

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
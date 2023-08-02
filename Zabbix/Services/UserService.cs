using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class UserService : CrudService<User, UserInclude, UserProperties,UserService.UserResult>
    {
        public UserService(ICore core) : base(core, "user")
        {
        }

        //TODO Make Async Variants
        public User Login(string username, string password, Dictionary<string, string> @params = null)
        {
            if(@params == null)
            {
                @params = new Dictionary<string, string>() { { "username", username }, { "password", password }, {"userData", "true"} };
            }
            return Core.SendRequest<User>(@params, ClassName+".login", null);

        }

        public void Logout()
        {
            
        }
        public class UserResult : BaseResult {
            [JsonProperty("userids")]
            public override string[] Ids { get; set; }
        }

        protected override Dictionary<string, object> BuildParams(
            RequestFilter<UserProperties, UserInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum UserInclude
    {
        selectMedias,
        selectMediatypes,
        selectUsrgrps,
        selectRole,
    }
}

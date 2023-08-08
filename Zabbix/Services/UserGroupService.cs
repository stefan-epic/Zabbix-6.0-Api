using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class UserGroupService : CrudService<UserGroup, UserGroupInclude, UserGroupProperties, UserGroupService.UserGroupResult>
    {

        public UserGroupService(ICore core) : base(core, "usergroup")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<UserGroupProperties, UserGroupInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class UserGroupResult : BaseResult
        {
            [JsonProperty("usrgrpids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum UserGroupInclude
    {
        selectTagFilters,
        selectUsers,
        selectRights
    }
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class UserGroupService : CrudService<UserGroup, GetUserGroupFilter, UserGroupService.UserGroupResult>
    {

        public UserGroupService(ICore core) : base(core, "usergroup")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class UserGroupResult : BaseResult
        {
            [JsonProperty("usrgrpids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetUserGroupFilter : GetFilter
    {
        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("userids")]
        public IList<string>? UserIds { get; set; }

        [JsonProperty("usrgrpids")]
        public IList<string>? UserGroupIds { get; set; }

        [JsonProperty("selectTagFilters")]
        public IList<string>? SelectTagFilters { get; set; }

        [JsonProperty("selectUsers")]
        public IList<string>? SelectUsers { get; set; }

        [JsonProperty("selectRights")]
        public IList<string>? SelectRights { get; set; }

        [JsonProperty("limitSelects")]
        public int? LimitSelects { get; set; }
    }

    public enum UserGroupInclude
    {
        selectTagFilters,
        selectUsers,
        selectRights
    }
}

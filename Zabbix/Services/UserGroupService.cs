using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class UserGroupService : CrudService<UserGroup, UserGroupFilterOptions, UserGroupService.UserGroupResult>
    {

        public UserGroupService(ICore core) : base(core, "usergroup")
        {
        }

        public class UserGroupResult : BaseResult
        {
            [JsonProperty("usrgrpids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class UserGroupFilterOptions : FilterOptions
    {
        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("userids")]
        public object? UserIds { get; set; }

        [JsonProperty("usrgrpids")]
        public object? UserGroupIds { get; set; }

        [JsonProperty("selectTagFilters")]
        public ZabbixQuery? SelectTagFilters { get; set; }

        [JsonProperty("selectUsers")]
        public ZabbixQuery? SelectUsers { get; set; }

        [JsonProperty("selectRights")]
        public ZabbixQuery? SelectRights { get; set; }

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

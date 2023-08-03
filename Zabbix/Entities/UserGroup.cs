using Newtonsoft.Json;

namespace Zabbix.Entities;

public class UserGroup : BaseEntitiy
{
    [JsonProperty("usrgrpid")] public override string EntityId { get; set; }

    [JsonProperty("name")] public string Name { get; set; }

    [JsonProperty("gui_access")] public string GuiAccess { get; set; }

    [JsonProperty("users_status")] public string UsersStatus { get; set; }

    [JsonProperty("debug_mode")] public string DebugMode { get; set; }
}
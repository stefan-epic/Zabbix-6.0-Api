using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public class UserGroup : BaseEntitiy
    {
        [JsonProperty("usrgrpid")]
        public string Usrgrpid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gui_access")]
        public string GuiAccess { get; set; }

        [JsonProperty("users_status")]
        public string UsersStatus { get; set; }

        [JsonProperty("debug_mode")]
        public string DebugMode { get; set; }
    }
}

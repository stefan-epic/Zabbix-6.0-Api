using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZabbixApi.Helper;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference/user/login
namespace Zabbix.Entities
{
    //TODO

    public class User : IBaseEntitiy
    {
        #region Properties
        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("autologin")]
        //[JsonConverter(typeof(IntToBoolConverter))]
        public string Autologin { get; set; }

        [JsonProperty("autologout")]
        public string Autologout { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("refresh")]
        public string Refresh { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("attempt_failed")]
        public string AttemptFailed { get; set; }

        [JsonProperty("attempt_ip")]
        public string AttemptIp { get; set; }

        //TODO: Not sure if this works
        [JsonProperty("attempt_clock")]
        [JsonConverter(typeof(TimestampToDateTimeConverter))]
        public DateTime AttemptClock { get; set; }

        [JsonProperty("rows_per_page")]
        public string RowsPerPage { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("roleid")]
        public string Roleid { get; set; }

        //TODO: Role type
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("userip")]
        public string UserIp { get; set; }

        [JsonProperty("debug_mode")]
        //[JsonConverter(typeof(IntToBoolConverter))]
        public string DebugMode { get; set; }

        //TODO: fix these
        [JsonProperty("gui_access")]
        public int GuiAccess { get; set; }

        //Auth token
        [JsonProperty("sessionid")]
        public string SessionId { get; set; }

        #endregion
    }
}

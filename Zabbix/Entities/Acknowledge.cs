using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class Acknowledge : BaseEntitiy
    {
        #region Properties


        [JsonProperty("acknowledgeid")]
        public override string EntityId { get; set; }

        [JsonProperty("userid")]
        public string Userid { get; set; }

        [JsonProperty("eventid")]
        public string Eventid { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("old_severity")]
        public string OldSeverity { get; set; }

        [JsonProperty("new_severity")]
        public string NewSeverity { get; set; }
        #endregion
    }
}

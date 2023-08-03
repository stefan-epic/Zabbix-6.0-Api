using Newtonsoft.Json;

namespace Zabbix.Entities
{
    //TODO

    public class UserMacro : BaseEntitiy
    {
        [JsonProperty("hostmacroid")]
        public override string EntityId { get; set; }

        [JsonProperty("hostid")]
        public string Hostid { get; set; }

        [JsonProperty("macro")]
        public string Macro { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
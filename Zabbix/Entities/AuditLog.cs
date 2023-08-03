using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum AuditLogProperties
    {
    }
    public class AuditLog : BaseEntitiy
    {
        #region Properties

        [JsonProperty("auditid")]
        public override string EntityId { get; set; }

        [JsonProperty("userid")]
        public string Userid { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("clock")]
        public string Clock { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("resourcetype")]
        public string Resourcetype { get; set; }

        [JsonProperty("resourceid")]
        public string Resourceid { get; set; }

        [JsonProperty("resourcename")]
        public string Resourcename { get; set; }

        [JsonProperty("recordsetid")]
        public string Recordsetid { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        #endregion


    }
}

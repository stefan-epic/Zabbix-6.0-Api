using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum TokenProperties
    {

    }
    public class Token : BaseEntitiy
    {
        #region Properties

        [JsonProperty("tokenid")]
        public override string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("lastaccess")]
        public DateTime LastAccess { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("creator_userid")]
        public string CreatorUserId { get; set; }

        #endregion

    }
}

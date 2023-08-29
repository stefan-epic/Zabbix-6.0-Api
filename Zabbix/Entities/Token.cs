using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum TokenProperties
    {

    }
    public class Token : BaseEntity
    {
        #region Properties

        [JsonProperty("tokenid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("userid")]
        public string? UserId { get; set; }

        [JsonProperty("lastaccess")]
        public string? LastAccess { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("expires_at")]
        public string? ExpiresAt { get; set; }

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("creator_userid")]
        public string? CreatorUserId { get; set; }

        #endregion

        #region Constructors

        public Token(string name)
        {
            Name = name;
        }
        public Token() { }

        #endregion

    }
}

using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum ScriptProperties
    {

    }
    public class Script : BaseEntity
    {
        #region Properties

        [JsonProperty("scriptid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("command")]
        public string? Command { get; set; }

        [JsonProperty("scope")]
        public int? Scope { get; set; }

        [JsonProperty("execute_on")]
        public int? ExecuteOn { get; set; }

        [JsonProperty("menu_path")]
        public string? MenuPath { get; set; }

        [JsonProperty("authtype")]
        public int? AuthType { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("publickey")]
        public string? PublicKey { get; set; }

        [JsonProperty("privatekey")]
        public string? PrivateKey { get; set; }

        [JsonProperty("port")]
        public string? Port { get; set; }

        [JsonProperty("groupid")]
        public string? GroupId { get; set; }

        [JsonProperty("usrgrpid")]
        public string? UserGroupId { get; set; }

        [JsonProperty("host_access")]
        public int? HostAccess { get; set; }

        [JsonProperty("confirmation")]
        public string? Confirmation { get; set; }

        [JsonProperty("timeout")]
        public string? Timeout { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
        #endregion

        #region Components

        [JsonProperty("parameters")]
        public IList<WebhookParameter>? Parameters { get; set; }
        [JsonProperty("groups")]
        public IList<HostGroup>? HostGroups { get; set; }
        [JsonProperty("hosts")]
        public IList<Host>? Hosts { get; set; }
        [JsonProperty("actions")]
        public IList<Action>? Actions { get; set; }

        #endregion

    }
    public class Debug
    {
        #region Properties

        [JsonProperty("logs")]
        public IList<LogEntry>? Logs { get; set; }

        [JsonProperty("ms")]
        public string? ExecutionDuration { get; set; }

        #endregion

    }
    public class WebhookParameter
    {
        #region Properties

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

    }
    public class LogEntry
    {
        #region Properties

        [JsonProperty("level")]
        public int? Level { get; set; }

        [JsonProperty("ms")]
        public string? TimeElapsed { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        #endregion

    }

}

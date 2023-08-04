using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum TriggerPrototypeProperties
    {

    }

    public class TriggerPrototype : BaseEntitiy
    {
        #region Properties

        [JsonProperty("triggerid")]
        public override string EntityId { get; set; }

        [JsonProperty("expression")]
        public string Expression { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }

        [JsonProperty("recovery_mode")]
        public string RecoveryMode { get; set; }

        [JsonProperty("recovery_expression")]
        public string RecoveryExpression { get; set; }

        [JsonProperty("correlation_mode")]
        public string CorrelationMode { get; set; }

        [JsonProperty("correlation_tag")]
        public string CorrelationTag { get; set; }

        [JsonProperty("manual_close")]
        public string ManualClose { get; set; }

        [JsonProperty("opdata")]
        public string Opdata { get; set; }

        [JsonProperty("discover")]
        public string Discover { get; set; }

        #endregion

        #region Components

        [JsonProperty("functions")] public IList<TriggerFunction> Functions { get; set; }
        [JsonProperty("discoveryRule")] public IList<LLDRule> LLdRules { get; set; }
        [JsonProperty("groups")] public IList<HostGroup> HostGroups { get; set; }
        [JsonProperty("hosts")] public IList<Host> Hosts { get; set; }
        [JsonProperty("items")] public IList<Item> Items { get; set; }
        [JsonProperty("tags")] public IList<Tag> Tags { get; set; }

        #endregion

    }

}

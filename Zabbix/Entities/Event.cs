using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum EventProperties
    {
        eventid,
        source,
        objectid,
        acknowledged,
        clock,
        ns,
        name,
        value,
        severity,
        r_eventid,
        c_eventid,
        correlationid,
        userid,
        supressed,
        opdata
    }

    public class Event : BaseEntitiy
    {
        #region Properties

        [JsonProperty("eventid")] public override string EntityId { get; set; }

        [JsonProperty("source")] public string Source { get; set; }

        [JsonProperty("object")] public string EventObject { get; set; }

        [JsonProperty("objectid")] public string ObjectId { get; set; }

        [JsonProperty("acknowledged")] public string Acknowledged { get; set; }

        [JsonProperty("clock")] public string Clock { get; set; }

        [JsonProperty("ns")] public string Ns { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("value")] public string Value { get; set; }

        [JsonProperty("severity")] public string Severity { get; set; }

        [JsonProperty("r_eventid")] public string REventId { get; set; }

        [JsonProperty("c_eventid")] public string CEventId { get; set; }

        [JsonProperty("correlationid")] public string CorrelationId { get; set; }

        [JsonProperty("userid")] public string UserId { get; set; }

        [JsonProperty("supressed")] public string Supressed { get; set; }

        [JsonProperty("opdata")] public string OpData { get; set; }

        #endregion

        #region Components

        [JsonProperty("urls")] public List<MediaType> Urls { get; set; }

        [JsonProperty("acknowledges")] public List<Acknowledge> Acknowledges { get; set; }

        [JsonProperty("suppression_data")] public List<SuppressionData> SuppressionData { get; set; }

        [JsonProperty("tags")] public List<Tag> Tags { get; set; }

        [JsonProperty("hosts")] List<Host> Hosts { get; set; }

        [JsonProperty("relatedObject")] List<object> RelatedObjects { get; set; }

        [JsonProperty("alerts")] List<Alert> Alerts { get; set; }

        #endregion
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum HousekeepingProperties
    {
        hk_events_mode,
        hk_events_trigger,
        hk_events_service,
        hk_events_internal,
        hk_events_discovery,
        hk_events_autoreg,
        hk_services_mode,
        hk_services,
        hk_audit_mode,
        hk_audit,
        hk_sessions_mode,
        hk_sessions,
        hk_history_mode,
        hk_history_global,
        hk_history,
        hk_trends_mode,
        hk_trends_global,
        hk_trends,
        db_extension,
        compression_status,
        compress_older,
        compression_availability
    }
    public class Housekeeping : BaseEntity
    {
        #region MyRegion

        [JsonProperty("hk_events_mode")]
        public int? HkEventsMode { get; set; }

        [JsonProperty("hk_events_trigger")]
        public string? HkEventsTrigger { get; set; }

        [JsonProperty("hk_events_service")]
        public string? HkEventsService { get; set; }

        [JsonProperty("hk_events_internal")]
        public string? HkEventsInternal { get; set; }

        [JsonProperty("hk_events_discovery")]
        public string? HkEventsDiscovery { get; set; }

        [JsonProperty("hk_events_autoreg")]
        public string? HkEventsAutoreg { get; set; }

        [JsonProperty("hk_services_mode")]
        public int? HkServicesMode { get; set; }

        [JsonProperty("hk_services")]
        public string? HkServices { get; set; }

        [JsonProperty("hk_audit_mode")]
        public int? HkAuditMode { get; set; }

        [JsonProperty("hk_audit")]
        public string? HkAudit { get; set; }

        [JsonProperty("hk_sessions_mode")]
        public int? HkSessionsMode { get; set; }

        [JsonProperty("hk_sessions")]
        public string? HkSessions { get; set; }

        [JsonProperty("hk_history_mode")]
        public int? HkHistoryMode { get; set; }

        [JsonProperty("hk_history_global")]
        public int? HkHistoryGlobal { get; set; }

        [JsonProperty("hk_history")]
        public string? HkHistory { get; set; }

        [JsonProperty("hk_trends_mode")]
        public int? HkTrendsMode { get; set; }

        [JsonProperty("hk_trends_global")]
        public int? HkTrendsGlobal { get; set; }

        [JsonProperty("hk_trends")]
        public string? HkTrends { get; set; }

        [JsonProperty("db_extension")]
        public string? DbExtension { get; set; }

        [JsonProperty("compression_status")]
        public int? CompressionStatus { get; set; }

        [JsonProperty("compress_older")]
        public string? CompressOlder { get; set; }

        [JsonProperty("compression_availability")]
        public int? CompressionAvailability { get; set; }

        #endregion

    }
}

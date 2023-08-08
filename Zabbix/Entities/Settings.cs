using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class Settings : BaseEntitiy
    {
        #region Properties

        [JsonProperty("default_lang")]
        public string? DefaultLanguage { get; set; }

        [JsonProperty("default_timezone")]
        public string? DefaultTimeZone { get; set; }

        [JsonProperty("default_theme")]
        public string? DefaultTheme { get; set; }

        [JsonProperty("search_limit")]
        public int? SearchLimit { get; set; }

        [JsonProperty("max_overview_table_size")]
        public int? MaxOverviewTableSize { get; set; }

        [JsonProperty("max_in_table")]
        public int? MaxInTable { get; set; }

        [JsonProperty("server_check_interval")]
        public int? ServerCheckInterval { get; set; }

        [JsonProperty("work_period")]
        public string? WorkPeriod { get; set; }

        [JsonProperty("show_technical_errors")]
        public int? ShowTechnicalErrors { get; set; }

        [JsonProperty("history_period")]
        public string? HistoryPeriod { get; set; }

        [JsonProperty("period_default")]
        public string? PeriodDefault { get; set; }

        [JsonProperty("max_period")]
        public string? MaxPeriod { get; set; }

        [JsonProperty("severity_color_0")]
        public string? SeverityColor0 { get; set; }

        [JsonProperty("severity_color_1")]
        public string? SeverityColor1 { get; set; }

        [JsonProperty("severity_color_2")]
        public string? SeverityColor2 { get; set; }

        [JsonProperty("severity_color_3")]
        public string? SeverityColor3 { get; set; }

        [JsonProperty("severity_color_4")]
        public string? SeverityColor4 { get; set; }

        [JsonProperty("severity_color_5")]
        public string? SeverityColor5 { get; set; }

        [JsonProperty("severity_name_0")]
        public string? SeverityName0 { get; set; }

        [JsonProperty("severity_name_1")]
        public string? SeverityName1 { get; set; }

        [JsonProperty("severity_name_2")]
        public string? SeverityName2 { get; set; }

        [JsonProperty("severity_name_3")]
        public string? SeverityName3 { get; set; }

        [JsonProperty("severity_name_4")]
        public string? SeverityName4 { get; set; }

        [JsonProperty("severity_name_5")]
        public string? SeverityName5 { get; set; }

        [JsonProperty("custom_color")]
        public int? CustomColor { get; set; }

        [JsonProperty("ok_period")]
        public string? OkPeriod { get; set; }

        [JsonProperty("blink_period")]
        public string? BlinkPeriod { get; set; }

        [JsonProperty("problem_unack_color")]
        public string? ProblemUnackColor { get; set; }

        [JsonProperty("problem_ack_color")]
        public string? ProblemAckColor { get; set; }

        [JsonProperty("ok_unack_color")]
        public string? OkUnackColor { get; set; }

        [JsonProperty("ok_ack_color")]
        public string? OkAckColor { get; set; }

        [JsonProperty("problem_unack_style")]
        public int? ProblemUnackStyle { get; set; }

        [JsonProperty("problem_ack_style")]
        public int? ProblemAckStyle { get; set; }

        [JsonProperty("ok_unack_style")]
        public int? OkUnackStyle { get; set; }

        [JsonProperty("ok_ack_style")]
        public int? OkAckStyle { get; set; }

        [JsonProperty("url")]
        public string? FrontendUrl { get; set; }

        [JsonProperty("discovery_groupid")]
        public int? DiscoveryGroupId { get; set; }

        [JsonProperty("default_inventory_mode")]
        public int? DefaultInventoryMode { get; set; }

        [JsonProperty("alert_usrgrpid")]
        public int? AlertUserGroupId { get; set; }

        [JsonProperty("snmptrap_logging")]
        public int? SNMPTrapLogging { get; set; }

        [JsonProperty("login_attempts")]
        public int? LoginAttempts { get; set; }

        [JsonProperty("login_block")]
        public string? LoginBlock { get; set; }

        [JsonProperty("validate_uri_schemes")]
        public int? ValidateUriSchemes { get; set; }

        [JsonProperty("uri_valid_schemes")]
        public string? UriValidSchemes { get; set; }

        [JsonProperty("x_frame_options")]
        public string? XFrameOptions { get; set; }

        [JsonProperty("iframe_sandboxing_enabled")]
        public int? IframeSandboxingEnabled { get; set; }

        [JsonProperty("iframe_sandboxing_exceptions")]
        public string? IframeSandboxingExceptions { get; set; }

        [JsonProperty("connect_timeout")]
        public string? ConnectTimeout { get; set; }

        [JsonProperty("socket_timeout")]
        public string? SocketTimeout { get; set; }

        [JsonProperty("media_type_test_timeout")]
        public string? MediaTypeTestTimeout { get; set; }

        [JsonProperty("item_test_timeout")]
        public string? ItemTestTimeout { get; set; }

        [JsonProperty("script_timeout")]
        public string? ScriptTimeout { get; set; }

        [JsonProperty("report_test_timeout")]
        public string? ReportTestTimeout { get; set; }

        [JsonProperty("auditlog_enabled")]
        public int? AuditLogEnabled { get; set; }

        [JsonProperty("ha_failover_delay")]
        public string? HAFailoverDelay { get; set; }

        [JsonProperty("geomaps_tile_provider")]
        public string? GeomapTileProvider { get; set; }

        [JsonProperty("geomaps_tile_url")]
        public string? GeomapTileUrl { get; set; }

        [JsonProperty("geomaps_max_zoom")]
        public int? GeomapMaxZoom { get; set; }

        [JsonProperty("geomaps_attribution")]
        public string? GeomapAttribution { get; set; }
        #endregion

    }

}

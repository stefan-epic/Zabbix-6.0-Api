using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum TemplateDashboardProperties
    {

    }
    public class TemplateDashboard : BaseEntity
    {
        #region Properties

        [JsonProperty("dashboardid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("templateid")]
        public string? TemplateId { get; set; }

        [JsonProperty("display_period")]
        public int? DisplayPeriod { get; set; }

        [JsonProperty("auto_start")]
        public int? AutoStart { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        #endregion

        #region Components

        [JsonProperty("pages")]
        public IList<TemplateDashboardPage>? Pages { get; set; }

        #endregion

    }
    public class TemplateDashboardPage
    {
        #region Properties

        [JsonProperty("dashboard_pageid")]
        public string? DashboardPageId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("display_period")]
        public int? DisplayPeriod { get; set; }

        #endregion

        #region Components

        [JsonProperty("widgets")]
        public IList<TemplateDashboardWidget>? Widgets { get; set; }

        #endregion


    }
    public class TemplateDashboardWidget
    {
        #region Properties

        [JsonProperty("widgetid")]
        public string? WidgetId { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("x")]
        public int? X { get; set; }

        [JsonProperty("y")]
        public int? Y { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("view_mode")]
        public int? ViewMode { get; set; }

        #endregion

        #region Components

        [JsonProperty("fields")]
        public IList<TemplateDashboardWidgetField>? Fields { get; set; }

        #endregion

    }
    public class TemplateDashboardWidgetField
    {
        #region Properties

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("value")]
        public object? Value { get; set; }

        #endregion

    }
}

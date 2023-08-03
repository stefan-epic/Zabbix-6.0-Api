using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class DashboardField : BaseEntitiy
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DashboardPage : BaseEntitiy
    {
        [JsonProperty("dashboard_pageid")]
        public override string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_period")]
        public string DisplayPeriod { get; set; }

        [JsonProperty("widgets")]
        public List<DashboardWidget> Widgets { get; set; }
    }

    public class Dashboard : BaseEntitiy
    {
        [JsonProperty("dashboardid")]
        public override string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("display_period")]
        public string DisplayPeriod { get; set; }

        [JsonProperty("auto_start")]
        public string AutoStart { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("pages")]
        public List<DashboardPage> Pages { get; set; }
    }

    public class DashboardWidget : BaseEntitiy
    {
        [JsonProperty("widgetid")]
        public override string EntityId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("view_mode")]
        public string ViewMode { get; set; }

        [JsonProperty("fields")]
        public List<DashboardField> Fields { get; set; }
    }
}
using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum GraphPrototypeProperties
    {

    }
    public class GraphPrototype : BaseEntitiy
    {
        #region Properties

        [JsonProperty("graphid")] public override string? EntityId { get; set; }

        [JsonProperty("height")] public int? Height { get; set; }

        [JsonProperty("name")] public string? Name { get; set; }

        [JsonProperty("width")] public int? Width { get; set; }

        [JsonProperty("graphtype")] public int? GraphType { get; set; }

        [JsonProperty("percent_left")] public float? PercentLeft { get; set; }

        [JsonProperty("percent_right")] public float? PercentRight { get; set; }

        [JsonProperty("show_3d")] public int? Show3D { get; set; }

        [JsonProperty("show_legend")] public int? ShowLegend { get; set; }

        [JsonProperty("show_work_period")] public int? ShowWorkPeriod { get; set; }

        [JsonProperty("templateid")] public string? TemplateId { get; set; }

        [JsonProperty("yaxismax")] public float? YAxisMax { get; set; }

        [JsonProperty("yaxismin")] public float? YAxisMin { get; set; }

        [JsonProperty("ymax_itemid")] public string? YMaxItemId { get; set; }

        [JsonProperty("ymax_type")] public int? YMaxType { get; set; }

        [JsonProperty("ymin_itemid")] public string? YMinItemId { get; set; }

        [JsonProperty("ymin_type")] public int? YMinType { get; set; }

        [JsonProperty("discover")] public int? Discover { get; set; }

        [JsonProperty("uuid")] public string? UUID { get; set; }

        #endregion

        #region Components

        [JsonProperty("discoveryRule")] IList<DiscoveryRule>? DiscoverRules { get; set; }
        [JsonProperty("gitems")] IList<GraphItem>? GraphItems { get; set; }
        [JsonProperty("groups")] IList<HostGroup>? HostGroups { get; set; }
        [JsonProperty("hosts")] IList<Host>? Hosts { get; set; }
        [JsonProperty("items")] IList<Item>? Items { get; set; }
        [JsonProperty("templates")] IList<Template>? Templates { get; set; }

        #endregion
    }
}
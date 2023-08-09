using Newtonsoft.Json;

namespace Zabbix.Entities;

//TODO
public enum GraphProperties
{

}
public class Graph : BaseEntitiy
{
    #region Properties

    [JsonProperty("graphid")] public override string? EntityId { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("width")] public int? Width { get; set; }

    [JsonProperty("height")] public int? Height { get; set; }

    [JsonProperty("yaxismin")] public string? Yaxismin { get; set; }

    [JsonProperty("yaxismax")] public string? Yaxismax { get; set; }

    [JsonProperty("templateid")] public string? Templateid { get; set; }

    [JsonProperty("show_work_period")] public int? ShowWorkPeriod { get; set; }

    [JsonProperty("show_triggers")] public int? ShowTriggers { get; set; }

    [JsonProperty("graphtype")] public int? Graphtype { get; set; }

    [JsonProperty("show_legend")] public int? ShowLegend { get; set; }

    [JsonProperty("show_3d")] public int? Show3d { get; set; }

    [JsonProperty("percent_left")] public string? PercentLeft { get; set; }

    [JsonProperty("percent_right")] public string? PercentRight { get; set; }

    [JsonProperty("ymin_type")] public int? YminType { get; set; }

    [JsonProperty("ymax_type")] public int? YmaxType { get; set; }

    [JsonProperty("ymin_itemid")] public string? YminItemid { get; set; }

    [JsonProperty("ymax_itemid")] public string? YmaxItemid { get; set; }

    [JsonProperty("flags")] public int? Flags { get; set; }

    #endregion

    #region Components

    [JsonProperty("groups")] public IList<HostGroup>? Groups { get; set; }
    [JsonProperty("templates")] public IList<Template>? Templates { get; set; }
    [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }
    [JsonProperty("items")] public IList<Item>? Items { get; set; }
    [JsonProperty("graphDiscovery")] public IList<GraphDiscovery>? GraphDiscoveries { get; set; }
    [JsonProperty("gitems")] public IList<GraphItem>? GraphItems { get; set; }
    [JsonProperty("discoveryRule")] public IList<DiscoveryRule>? DiscoveryRules { get; set; }

    #endregion
}

public class GraphDiscovery
{
    [JsonProperty("graphid")] public string? GraphId;
    [JsonProperty("parent_graphid")] public string? ParentGraphId;
}
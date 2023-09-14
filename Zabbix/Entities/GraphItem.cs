using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class GraphItem : BaseEntity
    {
        #region Properties

        [JsonProperty("gitemid")]
        public override string? EntityId { get; set; }

        [JsonProperty("color")]
        public string? Color { get; set; }

        [JsonProperty("itemid")]
        public string? ItemId { get; set; }

        [JsonProperty("calc_fnc")]
        public int? CalculationFunction { get; set; }

        [JsonProperty("drawtype")]
        public int? DrawType { get; set; }

        [JsonProperty("graphid")]
        public string? GraphId { get; set; }

        [JsonProperty("sortorder")]
        public int? SortOrder { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("yaxisside")]
        public int? YAxisSide { get; set; }

        #endregion

        #region Components

        [JsonProperty("graphs")] public IList<Graph>? Graphs { get; set; }

        #endregion

        #region Constructors

        public GraphItem(string color, string itemid)
        {
            Color = color;
            ItemId = itemid;
        }

        public GraphItem()
        {

        }

        #endregion
    }
}

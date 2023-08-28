using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum GraphItemProperties
    {

    }
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

        [JsonProperty("graphs")] public IList<Graph> Graphs { get; set; }

        #endregion
    }
}

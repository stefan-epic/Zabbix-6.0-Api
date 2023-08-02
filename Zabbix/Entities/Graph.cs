using Newtonsoft.Json;

namespace Zabbix.Entities
{
    //TODO
    public class Graph : IBaseEntitiy
    {
        #region Properties
        [JsonProperty("graphid")]
        public string Graphid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("yaxismin")]
        public string Yaxismin { get; set; }

        [JsonProperty("yaxismax")]
        public string Yaxismax { get; set; }

        [JsonProperty("templateid")]
        public string Templateid { get; set; }

        [JsonProperty("show_work_period")]
        public string ShowWorkPeriod { get; set; }

        [JsonProperty("show_triggers")]
        public string ShowTriggers { get; set; }

        [JsonProperty("graphtype")]
        public string Graphtype { get; set; }

        [JsonProperty("show_legend")]
        public string ShowLegend { get; set; }

        [JsonProperty("show_3d")]
        public string Show3d { get; set; }

        [JsonProperty("percent_left")]
        public string PercentLeft { get; set; }

        [JsonProperty("percent_right")]
        public string PercentRight { get; set; }

        [JsonProperty("ymin_type")]
        public string YminType { get; set; }

        [JsonProperty("ymax_type")]
        public string YmaxType { get; set; }

        [JsonProperty("ymin_itemid")]
        public string YminItemid { get; set; }

        [JsonProperty("ymax_itemid")]
        public string YmaxItemid { get; set; }

        [JsonProperty("flags")]
        public string Flags { get; set; }
        #endregion
    }
}
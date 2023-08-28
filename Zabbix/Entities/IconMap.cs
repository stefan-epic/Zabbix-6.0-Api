using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum IconMapProperties
    {

    }
    public class IconMapping
    {
        #region Properties

        [JsonProperty("iconmappingid")]
        public string? IconMappingId { get; set; }

        [JsonProperty("iconid")]
        public string? IconId { get; set; }

        [JsonProperty("expression")]
        public string? Expression { get; set; }

        [JsonProperty("inventory_link")]
        public int? InventoryLink { get; set; }

        [JsonProperty("iconmapid")]
        public string? IconMapId { get; set; }

        [JsonProperty("sortorder")]
        public int? SortOrder { get; set; }

        #endregion

    }

    public class IconMap : BaseEntity
    {
        #region Properties


        [JsonProperty("iconmapid")]
        public override string? EntityId { get; set; }

        [JsonProperty("default_iconid")]
        public string? DefaultIconId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
        #endregion


        #region Components


        [JsonProperty("mappings")] IList<IconMapping> IconMappings {get; set; }

        #endregion

    }
}

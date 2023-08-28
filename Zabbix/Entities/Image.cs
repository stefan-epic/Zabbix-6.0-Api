using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum ImageProperties
    {

    }
    public class Image : BaseEntity
    {
        [JsonProperty("imageid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("imagetype")]
        public int? ImageType { get; set; }
    }
}

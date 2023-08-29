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
        #region Properties

        [JsonProperty("imageid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("imagetype")]
        public int? ImageType { get; set; }

        [JsonProperty("ImageBase64")]
        public string? ImageBase64 { get; set; }
        #endregion

        #region Constructors

        public Image(string name, int imageType, string imageBase64Base64)
        {
            Name = name;
            ImageType = imageType;
            ImageBase64 = imageBase64Base64;
        }
        public Image(){}

        #endregion

    }
}

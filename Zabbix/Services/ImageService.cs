using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ImageService : CrudService<Image, ImageFilterOptions, ImageService.ImageResult>
    {

        public ImageService(ICore core) : base(core, "image")
        {
        }

  
        public class ImageResult : BaseResult
        {
            [JsonProperty("imageids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public class ImageFilterOptions : FilterOptions
    {
        [JsonProperty("imageids")]
        public object? ImageIds { get; set; }

        [JsonProperty("sysmapids")]
        public object? SysMapIds { get; set; }

        [JsonProperty("select_image")]
        public int? SelectImage { get; set; }
    }

    public enum ImageInclude
    {
    }
}

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
    public class ImageService : CrudService<Image, ImageInclude, ImageProperties, ImageService.ImageResult>
    {

        public ImageService(ICore core) : base(core, "image")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<ImageProperties, ImageInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class ImageResult : BaseResult
        {
            [JsonProperty("imageids")]
            public override IList<string>? Ids { get; set; }
        }

    }

    public enum ImageInclude
    {
    }
}

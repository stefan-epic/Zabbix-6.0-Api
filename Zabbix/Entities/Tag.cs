using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public class Tag : BaseEntitiy
    {
        [JsonProperty("tag")]
        public string TagName { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

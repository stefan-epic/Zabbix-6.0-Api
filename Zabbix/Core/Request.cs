using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Core
{
    internal class Request
    {
        [JsonProperty("jsonrpc")]
        public string JSonRcp { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
        [JsonProperty("params")]
        public object Params { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("auth")]
        public string Auth { get; set; }

        public Request()
        {
            JSonRcp = "2.0";
        }
    }
}

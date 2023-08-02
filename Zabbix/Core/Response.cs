using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Core
{
    internal class Response<T>
    {
        [JsonProperty("jsonrpc")]
        public string JSonRcp { get; set; }
        [JsonProperty("result")]
        public T Result { get; set; }
        [JsonProperty("error")]
        public Error Error { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

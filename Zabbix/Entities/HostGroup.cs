using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZabbixApi.Helper;

namespace Zabbix.Entities
{
    //TODO

    public class HostGroup : IBaseEntitiy
    {
        #region Properties
        [JsonProperty("groupid")]
        public string Groupid { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonConverter(typeof(IntToBoolConverter))]
        [JsonProperty("internal")]
        public bool Internal { get; set; }
        [JsonProperty("flags")]
        public string Flags { get; set; }
        #endregion

        #region Components
        //Select discoveryrule
        //select groupdiscovery
        [JsonProperty("hosts")]
        public IList<Host> Hosts { get; set; }
        [JsonProperty("templates")]
        public IList<Template> Templates { get; set; }
        #endregion


        public override string ToString()
        {
            return $"Group ID: {Groupid}, Name: {Name}, Internal: {Internal}, Flags: {Flags}";
        }

    }
}

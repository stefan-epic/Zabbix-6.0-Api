using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZabbixApi.Helper;

namespace Zabbix.Entities
{
    public enum HostGroupProperties
    {
        groupid,
        name,
        @internal,
        flags
    }
    //TODO

    public class HostGroup : BaseEntitiy
    {
        #region Properties

        [JsonProperty("groupid")] public override string EntityId { get; set; }
        [JsonProperty("name")] public string Name { get; set; }

        [JsonConverter(typeof(IntToBoolConverter))]
        [JsonProperty("internal")]
        public bool Internal { get; set; }

        [JsonProperty("flags")] public string Flags { get; set; }

        #endregion

        #region Components

        //Select discoveryrule
        //select groupdiscovery
        [JsonProperty("hosts")] public IList<Host> Hosts { get; set; }
        [JsonProperty("templates")] public IList<Template> Templates { get; set; }

        #endregion

        #region Constructors

        public HostGroup(string name)
        {
            Name = name;
        }
        public HostGroup()
        {
        }

        #endregion

        public override string ToString()
        {
            return $"Group ID: {EntityId}, Name: {Name}, Internal: {Internal}, Flags: {Flags}";
        }
    }
}
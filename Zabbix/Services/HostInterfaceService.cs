using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Filter.FilterEnums;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    //TODO
    public class HostInterfaceService : CrudService<HostInterface, HostInterfaceInclude, HostInterfaceProperties, HostInterfaceService.HostInterfaceResult>
    {
        public HostInterfaceService(ICore core) : base(core, "hostinterface")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<HostInterfaceProperties, HostInterfaceInclude> filter, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class HostInterfaceResult : BaseResult
        {
            [JsonProperty("interfaceids")]
            public override string[] Ids { get; set; }
        }
    }

    public enum HostInterfaceInclude
    {
    }
}

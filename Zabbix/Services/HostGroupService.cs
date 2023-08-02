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
using ZabbixApi.Helper;

namespace Zabbix.Services
{

    public class HostGroupService : CrudService<HostGroup, HostGroupInclude, HostGroupProperties, HostGroupService.HostGroupResult>
    {
        public HostGroupService(ICore core) : base(core, "hostgroup")
        {

        }
        protected override Dictionary<string, object> BuildParams(RequestFilter<HostGroupProperties, HostGroupInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class HostGroupResult : BaseResult
        {
            [JsonProperty("hostgroupids")]
            public override string[] Ids { get; set; }
        }
    }

    public enum HostGroupInclude
    {
        selectDiscoveryRule,
        selectGroupDiscovery,
        selectHosts,
        selectTemplates
    }
}

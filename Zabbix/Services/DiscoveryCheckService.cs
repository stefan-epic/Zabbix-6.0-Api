using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class DiscoveryCheckService : GetService<DiscoveryCheck, DiscoveryCheckInclude, DiscoverRuleProperties>
    {
        public DiscoveryCheckService(ICore core) : base(core, "dcheck")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<DiscoverRuleProperties, DiscoveryCheckInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum DiscoveryCheckInclude
    {
    }
}

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
    public class DiscoveredServiceService : GetService<DiscoveredService, DiscoveredServiceInclude, DiscoveredServiceProperties>
    {
        public DiscoveredServiceService(ICore core) : base(core, "dcheck")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<DiscoveredServiceProperties, DiscoveredServiceInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum DiscoveredServiceInclude
    {
    }
}

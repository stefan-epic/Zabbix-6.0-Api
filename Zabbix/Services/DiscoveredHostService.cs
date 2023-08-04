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
    public class DiscoveredHostService : GetService<DiscoveredHost, DiscoveredHostInclude, DiscoveredHostProperties>
    {
        public DiscoveredHostService(ICore core) : base(core, "dhost")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<DiscoveredHostProperties, DiscoveredHostInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum DiscoveredHostInclude
    {
        selectDRules,
        selectDServices
    }
}

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
    public class GraphItemService : GetService<GraphItem, GraphItemInclude, GraphItemProperties>
    {
        public GraphItemService(ICore core) : base(core, "graphitem")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<GraphItemProperties, GraphItemInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum GraphItemInclude
    {
        selectGraphs
    }
}

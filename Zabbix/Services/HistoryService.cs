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
    //TODO: method clear
    public class HistoryService : GetService<History, HistoyInclude, HistoryProperties>
    {
        public HistoryService(ICore core) : base(core, "history")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<HistoryProperties, HistoyInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum HistoyInclude
    {
    }
}

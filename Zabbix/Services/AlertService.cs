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
    public class AlertService : GetService<Alert, AlertInclude, AlertProperties>
    {
        public AlertService(ICore core) : base(core, "alert")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<AlertProperties, AlertInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum AlertInclude
    {
        
    }
}

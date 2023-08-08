using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class AutoregistrationService : GetAndUpdateService<Autoregistration, AutoregistrationInclude, AutoregistrationProperties, bool>
    {

        public AutoregistrationService(ICore core) : base(core, "autoregistration")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<AutoregistrationProperties, AutoregistrationInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }

    }

    public enum AutoregistrationInclude
    {
    }
}

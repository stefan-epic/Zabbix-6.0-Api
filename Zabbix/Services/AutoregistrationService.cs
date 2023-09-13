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
    public class AutoregistrationService : GetAndUpdateService<Autoregistration, AutoregistrationFilterOptions, bool>
    {

        public AutoregistrationService(ICore core) : base(core, "autoregistration")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }

    }

    public enum AutoregistrationInclude
    {
    }
    public class AutoregistrationFilterOptions : FilterOptions
    {
        //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
    }
}

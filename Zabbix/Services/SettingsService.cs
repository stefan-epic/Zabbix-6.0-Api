using Newtonsoft.Json;
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
    public class SettingsService : GetAndUpdateService<Settings, SettingsFilterOptions, object>
    {
        public SettingsService(ICore core) : base(core, "settings")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
           return BaseBuildParams(filter);
        }
    }

    public class SettingsFilterOptions : FilterOptions
    {

    }

}

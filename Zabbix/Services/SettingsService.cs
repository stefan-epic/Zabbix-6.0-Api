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
    public class SettingsService : GetAndUpdateService<Settings, SettingsInclude, SettingsProperties, object>
    {
        public SettingsService(ICore core) : base(core, "settings")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<SettingsProperties, SettingsInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
           return BaseBuildParams(filter, @params);
        }
    }

    public enum SettingsInclude 
    {
    }
}

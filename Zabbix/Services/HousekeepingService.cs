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
    //TODO this sucks aswell
    public class HousekeepingService : GetAndUpdateService<Housekeeping, HousekeepingInclude, HousekeepingProperties, object>
    {

        public HousekeepingService(ICore core) : base(core, "housekeeping")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<HousekeepingProperties, HousekeepingInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }

    }

    public enum HousekeepingInclude 
    {
    }
}

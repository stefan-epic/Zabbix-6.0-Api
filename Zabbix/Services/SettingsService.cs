using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class SettingsService :  ServiceBase
    {
        public SettingsService(ICore core) : base(core, "settings")
        {
        }

        #region Get

        public Settings Get(SettingsFilterOptions? filter = null)
        {
            return Core.SendRequest<Settings>(BuildParams(filter), ClassName + ".get");

        }

        public async Task<Settings> GetAsync(SettingsFilterOptions? filter = null)
        {
            return await Core.SendRequestAsync<Settings>(BuildParams(filter), ClassName + ".get");

        }

        #endregion

        #region Update
        public IEnumerable<string> Update(Settings entity)
        {
            var ret = Core.SendRequest<IEnumerable<string>>(entity, ClassName + ".update");
            return ret;
        }
        public async Task<IEnumerable<string>> UpdateAsync(Settings entity)
        {
            var ret = await Core.SendRequestAsync<IEnumerable<string>>(entity, ClassName + ".update");
            return ret;
        }

        #endregion
    }

    public class SettingsFilterOptions : FilterOptions
    {

    }

}

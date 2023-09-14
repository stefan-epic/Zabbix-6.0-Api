using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class SettingsService :  ServiceBase, IGetService<Settings, SettingsFilterOptions>, IUpdateService<Settings, IEnumerable<string>>
    {
        private GetService<Settings, SettingsFilterOptions> _getService;
        public SettingsService(ICore core) : base(core, "settings")
        {
            _getService = new(core, "settings");
        }

        #region Get

        public IEnumerable<Settings> Get(SettingsFilterOptions? filter = null)
        {
            return _getService.Get(filter);
        }

        public async Task<IEnumerable<Settings>> GetAsync(SettingsFilterOptions? filter = null)
        {
            return await _getService.GetAsync(filter);
        }

        #endregion

        #region Update
        public virtual IEnumerable<IEnumerable<string>> Update(IEnumerable<Settings> entities)
        {
            var ret = Core.SendRequest<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update");
            return ret;
        }

        public virtual IEnumerable<string> Update(Settings entity)
        {
            var ret = Update(new List<Settings> { entity }).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public virtual async Task<IEnumerable<IEnumerable<string>>> UpdateAsync(IEnumerable<Settings> entities)
        {
            var ret = (await Core.SendRequestAsync<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update"));
            return ret;
        }

        public virtual async Task<IEnumerable<string>> UpdateAsync(Settings entity)
        {
            var ret = (await UpdateAsync(new List<Settings> { entity })).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion
    }

    public class SettingsFilterOptions : FilterOptions
    {

    }

}

using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class HousekeepingService : ServiceBase, IGetService<Housekeeping, HousekeepingFilterOptions>, IUpdateService<Housekeeping, IEnumerable<string>>
    {
        private GetService<Housekeeping, HousekeepingFilterOptions> _getService;

        public HousekeepingService(ICore core) : base(core, "housekeeping")
        {
            _getService = new(core, "housekeeping");
        }

        #region Get

        public IEnumerable<Housekeeping> Get(HousekeepingFilterOptions? filter = null)
        {
            return _getService.Get(filter);
        }

        public async Task<IEnumerable<Housekeeping>> GetAsync(HousekeepingFilterOptions? filter = null)
        {
            return await _getService.GetAsync(filter);
        }

        #endregion

        #region Update
        public virtual IEnumerable<IEnumerable<string>> Update(IEnumerable<Housekeeping> entities)
        {
            var ret = Core.SendRequest<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update");
            return ret;
        }

        public virtual IEnumerable<string> Update(Housekeeping entity)
        {
            var ret = Update(new List<Housekeeping> { entity }).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public virtual async Task<IEnumerable<IEnumerable<string>>> UpdateAsync(IEnumerable<Housekeeping> entities)
        {
            var ret = (await Core.SendRequestAsync<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update"));
            return ret;
        }

        public virtual async Task<IEnumerable<string>> UpdateAsync(Housekeeping entity)
        {
            var ret = (await UpdateAsync(new List<Housekeeping> { entity })).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion

    }

    public class HousekeepingFilterOptions : FilterOptions
    {

    }
}

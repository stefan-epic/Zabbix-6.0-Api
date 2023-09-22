using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class HousekeepingService : ServiceBase
    {
        public HousekeepingService(ICore core) : base(core, "housekeeping")
        {
        }

        #region Get

        public Housekeeping Get(HousekeepingFilterOptions? filter = null)
        {
            return Core.SendRequest<Housekeeping>(BuildParams(filter), ClassName + ".get");
        }

        public async Task<Housekeeping> GetAsync(HousekeepingFilterOptions? filter = null)
        {
            return await Core.SendRequestAsync<Housekeeping>(BuildParams(filter), ClassName + ".get");
        }

        #endregion

        #region Update
        public IEnumerable<string> Update(Housekeeping entity)
        {
            var ret = Core.SendRequest<IEnumerable<string>>(entity, ClassName + ".update");
            return ret;
        }
        public async Task<IEnumerable<string>> UpdateAsync(Housekeeping entity)
        {
            var ret = await Core.SendRequestAsync<IEnumerable<string>>(entity, ClassName + ".update");
            return ret;
        }

        #endregion

    }

    public class HousekeepingFilterOptions : FilterOptions
    {

    }
}

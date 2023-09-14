using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class AutoregistrationService : ServiceBase, IGetService<Autoregistration, AutoregistrationFilterOptions>, IUpdateService<Autoregistration, IEnumerable<string>>
    {
        private GetService<Autoregistration, AutoregistrationFilterOptions> _getService;
        public AutoregistrationService(ICore core) : base(core, "autoregistration")
        {
            _getService = new(core, "autoregistration");
        }

        #region Get

        public IEnumerable<Autoregistration> Get(AutoregistrationFilterOptions? filter = null)
        {
            return _getService.Get(filter);
        }

        public async Task<IEnumerable<Autoregistration>> GetAsync(AutoregistrationFilterOptions? filter = null)
        {
            return await _getService.GetAsync(filter);
        }

        #endregion

        #region Update
        public virtual IEnumerable<IEnumerable<string>> Update(IEnumerable<Autoregistration> entities)
        {
            var ret = Core.SendRequest<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update");
            return ret;
        }

        public virtual IEnumerable<string> Update(Autoregistration entity)
        {
            var ret = Update(new List<Autoregistration> { entity }).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public virtual async Task<IEnumerable<IEnumerable<string>>> UpdateAsync(IEnumerable<Autoregistration> entities)
        {
            var ret = (await Core.SendRequestAsync<IEnumerable<IEnumerable<string>>>(entities, ClassName + ".update"));
            return ret;
        }

        public virtual async Task<IEnumerable<string>> UpdateAsync(Autoregistration entity)
        {
            var ret = (await UpdateAsync(new List<Autoregistration> { entity })).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion
    }

    public class AutoregistrationFilterOptions : FilterOptions
    {
        //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
    }
}

using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class AutoRegistrationService : ServiceBase
    {
        private GetService<Autoregistration, AutoregistrationFilterOptions> _getService;
        public AutoRegistrationService(ICore core) : base(core, "autoregistration")
        {
            _getService = new(core, "autoregistration");
        }

        #region Get

        public Autoregistration Get(AutoregistrationFilterOptions? filter = null)
        {
            return Core.SendRequest<Autoregistration>(BuildParams(filter), ClassName + ".get");
        }

        public async Task<Autoregistration> GetAsync(AutoregistrationFilterOptions? filter = null)
        {
            return await Core.SendRequestAsync<Autoregistration>(BuildParams(filter), ClassName + ".get");
        }

        #endregion

        #region Update
        public virtual bool Update(Autoregistration entity)
        {
            var ret = Core.SendRequest<bool>(entity, ClassName + ".update");
            return ret;
        }

        public async Task<bool> UpdateAsync(Autoregistration entity)
        {
            var ret = await Core.SendRequestAsync<bool>(entity, ClassName + ".update");
            return ret;
        }

        #endregion
    }

    public class AutoregistrationFilterOptions : FilterOptions
    {
        //TODO: only supports output https://www.zabbix.com/documentation/current/en/manual/api/reference/authentication/get
    }
}

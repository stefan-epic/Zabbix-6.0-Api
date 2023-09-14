using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;
using static System.Formats.Asn1.AsnWriter;

namespace Zabbix.Services
{
    public class AutoregistrationService : IGetService<Autoregistration, AutoregistrationFilterOptions>, IUpdateService<Autoregistration, IEnumerable<string>>
    {
        private GetService<Autoregistration, AutoregistrationFilterOptions> _getService;
        private string _className;
        private ICore _core;
        public AutoregistrationService(ICore core)
        {
            _core = core;
            _className = "autoregistration";
            _getService = new(core, _className);
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
            var ret = _core.SendRequest<IEnumerable<IEnumerable<string>>>(entities, _className + ".update");
            return ret;
        }

        public virtual IEnumerable<string> Update(Autoregistration entity)
        {
            var ret = Update(new List<Autoregistration> { entity }).FirstOrDefault();
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public virtual async Task<IEnumerable<IEnumerable<string>>> UpdateAsync(IEnumerable<Autoregistration> entities)
        {
            var ret = (await _core.SendRequestAsync<IEnumerable<IEnumerable<string>>>(entities, _className + ".update"));
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

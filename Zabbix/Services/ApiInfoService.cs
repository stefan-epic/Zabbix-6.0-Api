using Zabbix.Core;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class ApiInfoService : ServiceBase
    {
        public ApiInfoService(ICore core) : base(core, "apiinfo")
        {
        }

        public string GetVersion()
        {
            return Core.SendRequest<string>(new List<object>(), "apiinfo.version", null);
        }
        public async Task<string> GetVersionAsync()
        {
            return await Core.SendRequestAsync<string>(null, "apiinfo.version");
        }
    }
}

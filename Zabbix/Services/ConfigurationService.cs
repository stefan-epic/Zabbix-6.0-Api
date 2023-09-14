using Zabbix.Core;
using Zabbix.Entities;

namespace Zabbix.Services
{
    public class ConfigurationService
    {
        private ICore _core;
        public ConfigurationService(ICore core)
        {
            _core = core;
        }
        public string Export(ExportConfiguration configuration)
        {
            return _core.SendRequest<string>(configuration, "configuration.export");
        }
        public bool Import(ImportConfiguration configuration)
        {
            return _core.SendRequest<bool>(configuration, "configuration.import");
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

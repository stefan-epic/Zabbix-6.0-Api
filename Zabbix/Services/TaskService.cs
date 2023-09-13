using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    public class TaskService : GetAndCreate<TaskObject, TaskObjectFilterOptions>
    {
        public TaskService(ICore core, string className) : base(core, className) { }
        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class TaskObjectFilterOptions : FilterOptions
    {
        [JsonProperty("taskids")]
        public object? TaskIds { get; set; }
    }

    public enum TaskObjectInclude
    {

    }
}

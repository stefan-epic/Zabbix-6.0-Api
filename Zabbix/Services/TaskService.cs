using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{

    public class TaskService : IGetService<TaskObject, TaskObjectFilterOptions>, ICreateService<TaskObject>
    {
        private GetService<TaskObject, TaskObjectFilterOptions> _getService;
        private CreateService<TaskObject, TaskResult> _createService;

        public TaskService(ICore core)
        {
            _getService = new(core, "task");
            _createService = new(core, "task");
        }

        #region Get

        public class TaskResult : BaseResult
        {
            [JsonProperty("taskids")] public override IList<string>? Ids { get; set; }
        }

        public IEnumerable<TaskObject> Get(TaskObjectFilterOptions? filter = null)
        {
            return _getService.Get(filter);
        }

        public async Task<IEnumerable<TaskObject>> GetAsync(TaskObjectFilterOptions? filter = null)
        {
            return await _getService.GetAsync(filter);

        }

        #endregion

        #region Create

        public IEnumerable<string> Create(IEnumerable<TaskObject> entities)
        {
            return _createService.Create(entities);
        }

        public string Create(TaskObject entity)
        {
            return _createService.Create(entity);
        }

        public async Task<IEnumerable<string>> CreateAsync(IEnumerable<TaskObject> entities)
        {
            return await _createService.CreateAsync(entities);
        }

        public async Task<string> CreateAsync(TaskObject entity)
        {
            return await _createService.CreateAsync(entity);
        }

        #endregion

    }

    public class TaskObjectFilterOptions : FilterOptions
    {
        [JsonProperty("taskids")]
        public object? TaskIds { get; set; }
    }
}

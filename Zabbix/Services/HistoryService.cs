using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class HistoryService : GetService<History, HistoryFilterOptions>
    {
        public HistoryService(ICore core) : base(core, "history")
        {
        }

        public IEnumerable<string> Clear(IEnumerable<History> histories)
        {
            var baseEntities = histories.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(history => history.EntityId);
            var ret = Core.SendRequest<HistoryResult>(ids, "history.clear").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IEnumerable<string>> ClearAsync(IEnumerable<History> histories)
        {
            var baseEntities = histories.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(history => history.EntityId);
            return Checker.ReturnEmptyListOrActual((await Core.SendRequestAsync<HistoryResult>(ids, "history.clear")).Ids);
        }


        public class HistoryResult : BaseResult
        {
            [JsonProperty("itemids")] public override IList<string>? Ids { get; set; }
        }
    }

    public class HistoryFilterOptions : FilterOptions
    {
        [JsonProperty("history")]
        public int? History { get; set; }

        [JsonProperty("hostids")]
        public object? HostIds { get; set; }

        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("time_from")]
        public string? TimeFrom { get; set; }

        [JsonProperty("time_till")]
        public string? TimeTill { get; set; }
    }

}

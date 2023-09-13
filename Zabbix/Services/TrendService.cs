using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TrendService
    {
        private ICore _core;
        public IntegerTrendService IntegerTrends { get; }
        public FloatTrendService FloatTrends { get; }
        public TrendService(ICore core)
        {
            _core = core;

            IntegerTrends = new IntegerTrendService(_core);
            FloatTrends = new FloatTrendService(_core);
        }


    }
    public class FloatTrendService : GetService<FloatTrend, TrendFilterOptions>
    {
        public FloatTrendService(ICore core) : base(core, "trend")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

   

    public class IntegerTrendService : GetService<IntegerTrend, TrendFilterOptions>
    {
        public IntegerTrendService(ICore core) : base(core, "trend")
        {
        }

        protected override Dictionary<string, object> BuildParams(FilterOptions? filter = null)
        {
            return BaseBuildParams(filter);
        }
    }

    public class TrendFilterOptions : FilterOptions
    {
        [JsonProperty("itemids")]
        public object? ItemIds { get; set; }

        [JsonProperty("time_from")]
        public string? TimeFrom { get; set; }

        [JsonProperty("time_till")]
        public string? TimeTill { get; set; }
    }

}

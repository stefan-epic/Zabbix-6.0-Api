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
    public class FloatTrendService : GetService<FloatTrend, TrendInclude, TrendProperties>
    {
        public FloatTrendService(ICore core) : base(core, "trend")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<TrendProperties, TrendInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }
    public class IntegerTrendService : GetService<IntegerTrend, TrendInclude, TrendProperties>
    {
        public IntegerTrendService(ICore core) : base(core, "trend")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<TrendProperties, TrendInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
    }

    public enum TrendInclude
    {
    }
}

using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ProblemService : GetService<Problem, ProblemInclude, ProblemProperties>
{
    public ProblemService(ICore core) : base(core, "problem")
    {
    }

    protected override Dictionary<string, object> BuildParams(RequestFilter<ProblemProperties, ProblemInclude> filter,
        Dictionary<string, object> @params = null)
    {
        return BaseBuildParams(filter, @params);
    }
}

public enum ProblemInclude
{
    selectAcknowledges,
    selectTags,
    selectSuppressionData
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ReportService : CrudService<Report, ReportInclude, ReportProperties, ReportService.ReportResult>
{
    public ReportService(ICore core) : base(core, "report")
    {
    }

    protected override Dictionary<string, object>? BuildParams(RequestFilter<ReportProperties, ReportInclude>? filter,
        Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }

    public class ReportResult : BaseResult
    {
        [JsonProperty("reportids")] public override IList<string>? Ids { get; set; }
    }
}

public enum ReportInclude
{
    selectUsers,
    selectUserGroups
}
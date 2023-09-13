using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ReportService : CrudService<Report, GetReportFilter, ReportService.ReportResult>
{
    public ReportService(ICore core) : base(core, "report")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter)
    {
        return BaseBuildParams(filter);
    }

    public class ReportResult : BaseResult
    {
        [JsonProperty("reportids")] public override IList<string>? Ids { get; set; }
    }
}

public class GetReportFilter : GetFilter
{
    [JsonProperty("reportids")]
    public IList<string>? ReportIds { get; set; }

    [JsonProperty("expired")]
    public bool? Expired { get; set; }

    [JsonProperty("selectUsers")]
    public IList<string>? SelectUsers { get; set; }

    [JsonProperty("selectUserGroups")]
    public IList<string>? SelectUserGroups { get; set; }
}

public enum ReportInclude
{
    selectUsers,
    selectUserGroups
}
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class ReportService : CrudService<Report, ReportFilterOptions, ReportService.ReportResult>
{
    public ReportService(ICore core) : base(core, "report")
    {
    }

    protected override Dictionary<string, object> BuildParams(FilterOptions? filter)
    {
        return BaseBuildParams(filter);
    }

    public class ReportResult : BaseResult
    {
        [JsonProperty("reportids")] public override IList<string>? Ids { get; set; }
    }
}

public class ReportFilterOptions : FilterOptions
{
    [JsonProperty("reportids")]
    public object? ReportIds { get; set; }

    [JsonProperty("expired")]
    public bool? Expired { get; set; }

    [JsonProperty("selectUsers")]
    public object? SelectUsers { get; set; }

    [JsonProperty("selectUserGroups")]
    public object? SelectUserGroups { get; set; }
}

public enum ReportInclude
{
    selectUsers,
    selectUserGroups
}
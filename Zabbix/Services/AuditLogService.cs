using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class AuditLogService : GetService<AuditLog, GetAuditLogFilter>
{
    public AuditLogService(ICore core) : base(core, "auditlog")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }
}
public class GetAuditLogFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("auditids")]
    public IList<string>? AuditIds { get; set; }

    [JsonProperty("userids")]
    public IList<string>? UserIds { get; set; }

    [JsonProperty("time_from")]
    public DateTime? TimeFrom { get; set; }

    [JsonProperty("time_till")]
    public DateTime? TimeTill { get; set; }
    #endregion
}
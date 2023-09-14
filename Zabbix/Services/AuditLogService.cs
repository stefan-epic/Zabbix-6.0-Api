using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class AuditLogService : GetService<AuditLog, AuditLogFilterOptions>
{
    public AuditLogService(ICore core) : base(core, "auditlog")
    {
    }

    
}
public class AuditLogFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("auditids")]
    public object? AuditIds { get; set; }

    [JsonProperty("userids")]
    public object? UserIds { get; set; }

    [JsonProperty("time_from")]
    public DateTime? TimeFrom { get; set; }

    [JsonProperty("time_till")]
    public DateTime? TimeTill { get; set; }
    #endregion
}
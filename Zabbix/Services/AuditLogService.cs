using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class AuditLogService : GetService<AuditLog, AuditLogInclude, AuditLogProperties>
{
    public AuditLogService(ICore core) : base(core, "auditlog")
    {
    }

    protected override Dictionary<string, object>? BuildParams(
        RequestFilter<AuditLogProperties, AuditLogInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return BaseBuildParams(filter, @params);
    }
}

public enum AuditLogInclude
{
}
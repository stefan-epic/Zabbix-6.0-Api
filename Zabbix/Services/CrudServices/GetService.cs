using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public abstract class GetService<TEntity, TEntityFilter> :
    ServiceBase, IGet<TEntity, TEntityFilter>
    where TEntity : BaseEntity
    where TEntityFilter : GetFilter
{
    protected GetService(ICore core, string className) : base(core, className)
    {
    }

    public IEnumerable<TEntity> Get(TEntityFilter? filter = null)
    {
        return Core.SendRequest<TEntity[]>(BuildParams(filter), ClassName + ".get");
    }

    public async Task<IEnumerable<TEntity>> GetAsync(TEntityFilter? filter = null,
        Dictionary<string, object>? @params = null)
    {
        return await Core.SendRequestAsync<TEntity[]>(BuildParams(filter), ClassName + ".get");

    }
}
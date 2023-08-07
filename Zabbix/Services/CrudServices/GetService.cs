using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public abstract class GetService<TEntity, TEntityInclude, TEntityProperty> :
    ServiceBase<TEntity, TEntityInclude, TEntityProperty>, IGet<TEntity, TEntityInclude, TEntityProperty>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
{
    protected GetService(ICore core, string className) : base(core, className)
    {
    }

    public IEnumerable<TEntity> Get(RequestFilter<TEntityProperty, TEntityInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return Core.SendRequest<TEntity[]>(BuildParams(filter, @params), ClassName + ".get");
    }

    public async Task<IEnumerable<TEntity>> GetAsync(RequestFilter<TEntityProperty, TEntityInclude>? filter = null, Dictionary<string, object>? @params = null)
    {
        return await Core.SendRequestAsync<TEntity[]>(BuildParams(filter, @params), ClassName + ".get");

    }
}
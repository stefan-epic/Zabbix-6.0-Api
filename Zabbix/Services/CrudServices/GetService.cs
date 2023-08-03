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
    public GetService(ICore core, string className) : base(core, className)
    {
    }

    public IEnumerable<TEntity> Get(RequestFilter<TEntityProperty, TEntityInclude> filter = null,
        Dictionary<string, object> @params = null)
    {
        return base.Get(filter, @params);
    }

    public Task<IEnumerable<TEntity>> GetAsync(Dictionary<string, object> @params = null,
        RequestFilter<TEntityProperty, TEntityInclude> filter = null)
    {
        throw new NotImplementedException();
    }
}
using Zabbix.Entities;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public interface IGet<TEntity, TEntityInclude, TEntityProperty>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
{
    IEnumerable<TEntity> Get(RequestFilter<TEntityProperty, TEntityInclude>? filter = null,
        Dictionary<string, object>? @params = null);

    Task<IEnumerable<TEntity>> GetAsync(RequestFilter<TEntityProperty, TEntityInclude>? filter = null,
        Dictionary<string, object>? @params = null);
}
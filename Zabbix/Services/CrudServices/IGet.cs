using Zabbix.Entities;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public interface IGet<TEntity, TEntityFilter>
    where TEntity : BaseEntity
    where TEntityFilter : FilterOptions
{
    IEnumerable<TEntity> Get(TEntityFilter? filter = null);

    Task<IEnumerable<TEntity>> GetAsync(TEntityFilter? filter = null,
        Dictionary<string, object>? @params = null);
}
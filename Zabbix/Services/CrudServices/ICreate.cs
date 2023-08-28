using Zabbix.Entities;

namespace Zabbix.Services.CrudServices;

//TODO: Maybe add some ---ById Methods for all of these
//not sure who need EntityInclude yet
public interface ICreate<TEntity>
    where TEntity : BaseEntity
{
    IEnumerable<string> Create(IEnumerable<TEntity> entity);
    string Create(TEntity entity);

    Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entity);
    Task<string> CreateAsync(TEntity entity);
}
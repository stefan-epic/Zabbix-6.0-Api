using Zabbix.Entities;

namespace Zabbix.Services.CrudServices
{
    public interface IUpdate<TEntity>
    where TEntity : IBaseEntitiy
    {
        IEnumerable<string> Update(IEnumerable<TEntity> entity);
        string Update(TEntity entity);

        Task<IReadOnlyList<string>> UpdateAsync(IEnumerable<TEntity> entity);
        Task<string> UpdateAsync(TEntity entity);
    }
}

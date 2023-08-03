using Zabbix.Entities;

namespace Zabbix.Services.CrudServices
{
    public interface IUpdate<TEntity>
    where TEntity : BaseEntitiy
    {
        IEnumerable<string> Update(IEnumerable<TEntity> entity);
        string Update(TEntity entity);

        Task<IEnumerable<string>> UpdateAsync(IEnumerable<TEntity> entity);
        Task<string> UpdateAsync(TEntity entity);
    }
}

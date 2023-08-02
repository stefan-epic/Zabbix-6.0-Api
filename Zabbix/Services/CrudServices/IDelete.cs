using Zabbix.Entities;

namespace Zabbix.Services.CrudServices
{
    public interface IDelete<TEntity>
    where TEntity : IBaseEntitiy
    {
        IEnumerable<string> Delete(IEnumerable<string> ids);
        string Delete(string id);
        IEnumerable<string> Delete(IEnumerable<TEntity> entities);
        string Delete(TEntity entity);

        Task<IReadOnlyList<string>> DeleteAsync(IEnumerable<string> ids);
        Task<string> DeleteAsync(string id);
        Task<IReadOnlyList<string>> DeleteAsync(IEnumerable<TEntity> entities);
        Task<string> DeleteAsync(TEntity entity);
    }
}

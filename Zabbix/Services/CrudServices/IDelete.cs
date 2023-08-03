using Zabbix.Entities;

namespace Zabbix.Services.CrudServices
{
    //TODO:add  byId methods
    public interface IDelete<TEntity>
    where TEntity : BaseEntitiy
    {
      //  IEnumerable<string> Delete(IEnumerable<string> ids);
       // string Delete(string id);
        IEnumerable<string> Delete(IEnumerable<TEntity> entities);
        string Delete(TEntity entity);

        //Task<IEnumerable<string>> DeleteAsync(IEnumerable<string> ids);
        //Task<string> DeleteAsync(string id);
        Task<IEnumerable<string>> DeleteAsync(IEnumerable<TEntity> entities);
        Task<string> DeleteAsync(TEntity entity);
    }
}

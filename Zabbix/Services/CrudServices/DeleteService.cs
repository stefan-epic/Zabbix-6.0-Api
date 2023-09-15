using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices
{
    public class DeleteService<TEntity, TEntityResult> : ServiceBase
    where TEntity : BaseEntity
    where TEntityResult : BaseResult
    {
        public DeleteService(ICore core, string className) : base(core, className) { }

        #region Delete

        public virtual string Delete(TEntity entity)
        {
            var ret = Delete(new List<string> { entity.EntityId! }).FirstOrDefault();
            return Checker.ReturnEmptyStringOrActual(ret);
        }

        public virtual string Delete(string id)
        {
            var ret = Delete(new List<string> { id }).FirstOrDefault();
            return Checker.ReturnEmptyStringOrActual(ret);
        }

        public virtual IEnumerable<string> Delete(IEnumerable<TEntity> entities)
        {
            var baseEntities = entities.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(e => e.EntityId).ToList();
            return Delete(ids!);
        }

        public virtual IEnumerable<string> Delete(List<string> ids)
        {

            Checker.CheckEntityIds(ids);
            var ret = Core.SendRequest<TEntityResult>(ids, ClassName + ".delete").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }



        public virtual async Task<string> DeleteAsync(TEntity entity)
        {
            var ret = (await DeleteAsync(new List<TEntity> { entity })).FirstOrDefault();
            return Checker.ReturnEmptyStringOrActual(ret);
        }

        public virtual async Task<string> DeleteAsync(string id)
        {
            var ret = (await DeleteAsync(new List<string> { id })).FirstOrDefault();
            return Checker.ReturnEmptyStringOrActual(ret);
        }

        public virtual async Task<IEnumerable<string>> DeleteAsync(IEnumerable<TEntity> entities)
        {
            var baseEntities = entities.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.ToList().Select(e => e.EntityId).ToList();
            var ret = await DeleteAsync(ids!);
            return ret;
        }

        public virtual async Task<IEnumerable<string>> DeleteAsync(IEnumerable<string> ids)
        {

            Checker.CheckEntityIds(ids);
            var ret = (await Core.SendRequestAsync<TEntityResult>(ids, ClassName + ".delete")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion
    }
}

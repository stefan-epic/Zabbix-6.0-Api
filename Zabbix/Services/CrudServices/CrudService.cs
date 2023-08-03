using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using ZabbixApi.Helper;

namespace Zabbix.Services.CrudServices
{
    //TODO: Maybe add createOrupdate methods
    public interface ICrudService<TEntity, TEntityInclude, TEntityProperty> : ICreate<TEntity>, IGet<TEntity, TEntityInclude, TEntityProperty>, IUpdate<TEntity>, IDelete<TEntity>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
    {

    }

    public abstract class CrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> : ServiceBase<TEntity, TEntityInclude, TEntityProperty>, ICrudService<TEntity, TEntityInclude, TEntityProperty>
        where TEntity : BaseEntitiy
        where TEntityInclude : struct, Enum
        where TEntityResult : BaseResult
        where TEntityProperty : Enum
    {

        public CrudService(ICore core, string className) : base(core, className) { }


        #region Get

        public virtual IEnumerable<TEntity> Get(RequestFilter<TEntityProperty, TEntityInclude> filter, Dictionary<string, object> @params = null)
        {
            return base.Get(filter, @params);
        }

        public async Task<IReadOnlyList<TEntity>> GetAsync(RequestFilter<TEntityProperty, TEntityInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return await base.GetAsync(filter, @params);
        }

        #endregion

        #region Create

        public virtual IEnumerable<string> Create(IEnumerable<TEntity> entities)
        {

            Check.EnumerableNotNullOrEmpty(entities);
            return Core.SendRequest<TEntityResult>(entities, ClassName + ".create").Ids;
        }

        public virtual string Create(TEntity entity)
        {
            Check.NotNull(entity, "entity");
            return Create(new List<TEntity>() { entity }).FirstOrDefault();

        }

        public virtual async Task<IReadOnlyList<string>> CreateAsync(IEnumerable<TEntity> entities)
        {
            Check.EnumerableNotNullOrEmpty(entities);

            return (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".create")).Ids;
        }
        public virtual async Task<string> CreateAsync(TEntity entity)
        {
            Check.NotNull(entity, "entity");

            return (await CreateAsync(new List<TEntity>() { entity })).FirstOrDefault();
        }

        #endregion

        #region Update

        public virtual IEnumerable<string> Update(IEnumerable<TEntity> entities)
        {
            Check.EnumerableNotNullOrEmpty(entities, "entities");

            return Core.SendRequest<TEntityResult>(entities, ClassName + ".update").Ids;
        }

        public virtual string Update(TEntity entity)
        {

            return Update(new List<TEntity>() { entity }).FirstOrDefault();
        }
        public virtual async Task<IReadOnlyList<string>> UpdateAsync(IEnumerable<TEntity> entities)
        {
            Check.EnumerableNotNullOrEmpty(entities, "entities");

            return (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".update")).Ids;
        }
        public virtual async Task<string> UpdateAsync(TEntity entity)
        {
            return (await UpdateAsync(new List<TEntity>() { entity })).FirstOrDefault();
        }
        #endregion

        #region Delete

        public virtual IEnumerable<string> Delete(IEnumerable<TEntity> entities)
        {
            return Core.SendRequest<TEntityResult>(entities, ClassName + ".delete").Ids;
        }

        public virtual string Delete(TEntity entity)
        {
            var id = entity.id;
            return Delete(new List<TEntity>(){entity.id}).FirstOrDefault();
        }



        public virtual async Task<IReadOnlyList<string>> DeleteAsync(IEnumerable<TEntity> entities)
        {
            return (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".delete")).Ids;
        }

        public virtual async Task<string> DeleteAsync(TEntity entity)
        {
            return (await DeleteAsync(new List<TEntity>() { entity })).FirstOrDefault();
        }

        #endregion

    }
}

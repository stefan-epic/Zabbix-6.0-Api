using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using ZabbixApi.Helper;

namespace Zabbix.Services.CrudServices;

//TODO: Maybe add createOrupdate methods
public interface ICrudService<TEntity, TEntityInclude, TEntityProperty> : ICreate<TEntity>,
    IGet<TEntity, TEntityInclude, TEntityProperty>, IUpdate<TEntity>, IDelete<TEntity>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
{
}

public abstract class CrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> :
    ServiceBase<TEntity, TEntityInclude, TEntityProperty>, ICrudService<TEntity, TEntityInclude, TEntityProperty>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityResult : BaseResult
    where TEntityProperty : Enum
{
    public CrudService(ICore core, string className) : base(core, className)
    {
    }


    #region Get

    public virtual IEnumerable<TEntity> Get(RequestFilter<TEntityProperty, TEntityInclude> filter,
        Dictionary<string, object> @params = null)
    {
        return base.Get(filter, @params);
    }

    public async Task<IEnumerable<TEntity>> GetAsync(RequestFilter<TEntityProperty, TEntityInclude> filter = null,
        Dictionary<string, object> @params = null)
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
        return Create(new List<TEntity> { entity }).FirstOrDefault();
    }

    public virtual async Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entities)
    {
        Check.EnumerableNotNullOrEmpty(entities);

        return (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".create")).Ids;
    }

    public virtual async Task<string> CreateAsync(TEntity entity)
    {
        Check.NotNull(entity, "entity");

        return (await CreateAsync(new List<TEntity> { entity })).FirstOrDefault();
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
        return Update(new List<TEntity> { entity }).FirstOrDefault();
    }

    public virtual async Task<IEnumerable<string>> UpdateAsync(IEnumerable<TEntity> entities)
    {
        Check.EnumerableNotNullOrEmpty(entities, "entities");

        return (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".update")).Ids;
    }

    public virtual async Task<string> UpdateAsync(TEntity entity)
    {
        return (await UpdateAsync(new List<TEntity> { entity })).FirstOrDefault();
    }

    #endregion

    #region Delete

    public virtual string Delete(TEntity entity)
    {
        return Delete(new List<string> { entity.EntityId }).FirstOrDefault();
    }

    public virtual string Delete(string id)
    {
        return Delete(new List<string> { id }).FirstOrDefault();
    }

    public virtual IEnumerable<string> Delete(IEnumerable<TEntity> entities)
    {
        var ids = entities.ToList().Select(e => e.EntityId).ToList();
        return Delete(ids);
    }

    public virtual IEnumerable<string> Delete(IEnumerable<string> id)
    {
        return Core.SendRequest<TEntityResult>(id, ClassName + ".delete").Ids;
    }


    public virtual async Task<string> DeleteAsync(TEntity entity)
    {
        return (await DeleteAsync(new List<TEntity> { entity })).FirstOrDefault();
    }

    public virtual async Task<string> DeleteAsync(string id)
    {
        return Delete(new List<string> { id }).FirstOrDefault();
    }

    public virtual async Task<IEnumerable<string>> DeleteAsync(IEnumerable<TEntity> entities)
    {
        var ids = entities.ToList().Select(e => e.EntityId).ToList();
        return await DeleteAsync(ids);
    }

    public virtual async Task<IEnumerable<string>> DeleteAsync(IEnumerable<string> id)
    {
        return (await Core.SendRequestAsync<TEntityResult>(id, ClassName + ".delete")).Ids;
    }

    #endregion
}
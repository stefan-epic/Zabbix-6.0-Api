using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices;

//TODO: Maybe add createOrupdate methods



public abstract class CrudService<TEntity, TEntityFilter, TEntityResult> : ServiceBase where TEntityResult : BaseResult where TEntity : BaseEntity where TEntityFilter : GetFilter
{
    protected CrudService(ICore core, string className) : base(core, className)
    {
    }


    #region Get

    public virtual IEnumerable<TEntity> Get(TEntityFilter? filter = null)
    {
        return Core.SendRequest<TEntity[]>(BuildParams(filter), ClassName + ".get");
    }

    public async Task<IEnumerable<TEntity>> GetAsync(TEntityFilter? filter = null)
    {
        return await Core.SendRequestAsync<TEntity[]>(BuildParams(filter), ClassName + ".get");
    }

    #endregion

    #region Create

    public virtual IEnumerable<string> Create(IEnumerable<TEntity> entities)
    {
        var ret = Core.SendRequest<TEntityResult>(entities, ClassName + ".create").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public virtual string Create(TEntity entity)
    {
        var ret = Create(new List<TEntity> { entity }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    public virtual async Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entities)
    {
        var ret = (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".create")).Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public virtual async Task<string> CreateAsync(TEntity entity)
    {
        var ret = (await CreateAsync(new List<TEntity> { entity })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    #endregion

    #region Update

    public virtual IEnumerable<string> Update(IEnumerable<TEntity> entities)
    {
        var ret = Core.SendRequest<TEntityResult>(entities, ClassName + ".update").Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public virtual string Update(TEntity entity)
    {
        var ret = Update(new List<TEntity> { entity }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    public virtual async Task<IEnumerable<string>> UpdateAsync(IEnumerable<TEntity> entities)
    {
        var ret = (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".update")).Ids;
        return Checker.ReturnEmptyListOrActual(ret);
    }

    public virtual async Task<string> UpdateAsync(TEntity entity)
    {
        var ret = (await UpdateAsync(new List<TEntity> { entity })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    #endregion

    #region Delete

    public virtual string Delete(TEntity entity)
    {
        Checker.CheckEntityId(entity);
        var ret = Delete(new List<string> { entity.EntityId! }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    public virtual string Delete(string id)
    {
        Checker.CheckEntityId(id);
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
        Checker.CheckEntityId(entity);
        var ret = (await DeleteAsync(new List<TEntity> { entity })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    public virtual async Task<string> DeleteAsync(string id)
    {
        Checker.CheckEntityId(id);

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
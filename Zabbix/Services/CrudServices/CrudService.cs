using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices;

//TODO: Maybe add createOrupdate methods



public abstract class CrudService<TEntity, TEntityFilter, TEntityResult>
    where TEntityResult : BaseResult 
    where TEntity : BaseEntity 
    where TEntityFilter : FilterOptions
{
    private readonly CreateService<TEntity, TEntityResult> _createService;
    private readonly GetService<TEntity, TEntityFilter> _getService;
    private readonly UpdateService<TEntity, TEntityResult> _updateService;
    private readonly DeleteService<TEntity, TEntityResult> _deleteService;

    protected ICore Core;
    protected string ClassName;
    protected CrudService(ICore core, string className)
    {
        _createService = new(core, className);
        _getService = new(core, className);
        _updateService = new(core, className);
        _deleteService = new(core, className);
        Core = core;
        ClassName = className;
    }


    #region Get

    public virtual IEnumerable<TEntity> Get(TEntityFilter? filter = null)
    {
        return _getService.Get(filter);
    }

    public async Task<IEnumerable<TEntity>> GetAsync(TEntityFilter? filter = null)
    {
        return await _getService.GetAsync(filter);
    }

    #endregion

    #region Create

    public virtual IEnumerable<string> Create(IEnumerable<TEntity> entities)
    {
        return _createService.Create(entities);
    }

    public virtual string Create(TEntity entity)
    {
        return _createService.Create(entity);
    }

    public virtual async Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entities)
    {
        return await _createService.CreateAsync(entities);

    }

    public virtual async Task<string> CreateAsync(TEntity entity)
    {
        return await _createService.CreateAsync(entity);

    }

    #endregion

    #region Update

    public virtual IEnumerable<string> Update(IEnumerable<TEntity> entities)
    {
        return _updateService.Update(entities);
    }

    public virtual string Update(TEntity entity)
    {
        return _updateService.Update(entity);
    }

    public virtual async Task<IEnumerable<string>> UpdateAsync(IEnumerable<TEntity> entities)
    {
        return await _updateService.UpdateAsync(entities);
    }

    public virtual async Task<string> UpdateAsync(TEntity entity)
    {
        return await _updateService.UpdateAsync(entity);
    }

    #endregion

    #region Delete

    public virtual string Delete(TEntity entity)
    {
        return _deleteService.Delete(entity);
    }

    public virtual string Delete(string id)
    {
        return _deleteService.Delete(id);
    }

    public virtual IEnumerable<string> Delete(IEnumerable<TEntity> entities)
    {
        return _deleteService.Delete(entities);
    }

    public virtual IEnumerable<string> Delete(List<string> ids)
    {
        return _deleteService.Delete(ids);
    }

    public virtual async Task<string> DeleteAsync(TEntity entity)
    {
        return await _deleteService.DeleteAsync(entity);

    }

    public virtual async Task<string> DeleteAsync(string id)
    {
        return await _deleteService.DeleteAsync(id);

    }

    public virtual async Task<IEnumerable<string>> DeleteAsync(IEnumerable<TEntity> entities)
    {
        return await _deleteService.DeleteAsync(entities);

    }

    public virtual async Task<IEnumerable<string>> DeleteAsync(IEnumerable<string> ids)
    {

        return await _deleteService.DeleteAsync(ids);

    }

    #endregion
}
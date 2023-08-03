using Zabbix.Core;
using Zabbix.Entities;

namespace Zabbix.Services.CrudServices;

public abstract class
    GetAndUpdateService<TEntity, TEntityInclude, TEntityProperty> :
        GetService<TEntity, TEntityInclude, TEntityProperty>, IUpdate<TEntity>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
{
    protected GetAndUpdateService(ICore core, string className) : base(core, className)
    {
    }

    //TODO:
    public IEnumerable<string> Update(IEnumerable<TEntity> entity)
    {
        throw new NotImplementedException();
    }

    public string Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<string>> UpdateAsync(IEnumerable<TEntity> entity)
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
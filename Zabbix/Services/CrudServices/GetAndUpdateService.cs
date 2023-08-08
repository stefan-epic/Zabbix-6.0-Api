using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices;

public abstract class
    GetAndUpdateService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> :
        GetService<TEntity, TEntityInclude, TEntityProperty>, IUpdate<TEntity>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
{
    protected GetAndUpdateService(ICore core, string className) : base(core, className)
    {
    }

    //TODO: this is horrible
    public virtual IEnumerable<string> Update(IEnumerable<TEntity> entities)
    {
        var ret = Core.SendRequest<TEntityResult>(entities, ClassName + ".update");
        if (ret == null)
        {
            return new List<string>();
        }

        var retStr = ret.ToString();
        return Checker.ReturnEmptyListOrActual(new List<string>(){retStr!});
    }

    public virtual string Update(TEntity entity)
    {
        var ret = Update(new List<TEntity> { entity }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }

    public virtual async Task<IEnumerable<string>> UpdateAsync(IEnumerable<TEntity> entities)
    {
        var ret = (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".update"));
        if (ret == null)
        {
            return new List<string>();
        }
        var retStr = ret.ToString();
        return Checker.ReturnEmptyListOrActual(new List<string>(){ retStr!});
    }

    public virtual async Task<string> UpdateAsync(TEntity entity)
    {
        var ret = (await UpdateAsync(new List<TEntity> { entity })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ret);
    }
}
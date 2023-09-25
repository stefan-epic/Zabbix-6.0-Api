using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public interface IGetService<TEntity, TEntityFilter> where TEntity : BaseEntity where TEntityFilter : FilterOptions
{
    IEnumerable<TEntity> Get(TEntityFilter? filter = null);
    Task<IEnumerable<TEntity>> GetAsync(TEntityFilter? filter = null);
}

public class GetService<TEntity, TEntityFilter> : ServiceBase, IGetService<TEntity, TEntityFilter> 
    where TEntity : BaseEntity 
    where TEntityFilter : FilterOptions
{
    public GetService(ICore core, string className) : base(core, className) { }

    public IEnumerable<TEntity> Get(TEntityFilter? filter = null)
    {
        return Core.SendRequest<TEntity[]>(BuildParams(filter), ClassName + ".get");
    }

    public async Task<IEnumerable<TEntity>> GetAsync(TEntityFilter? filter = null)
    {
        return await Core.SendRequestAsync<TEntity[]>(BuildParams(filter), ClassName + ".get");

    }
    public int CountOutput(TEntityFilter? filter = null)
    {
        var paramFilter = BuildParams(filter);
        paramFilter.Add("countOutput", "true");
        return Core.SendRequest<int>(paramFilter, ClassName + ".get");
    }

    public Dictionary<string, TEntity> PreserveKeys(TEntityFilter? filter = null)
    {
        var paramFilter = BuildParams(filter);
        paramFilter.Add("preservekeys", "true");
        return Core.SendRequest<Dictionary<string, TEntity>>(paramFilter, ClassName + ".get");
    }

    public async Task<int> CountOutputAsync(TEntityFilter? filter = null)
    {
        var paramFilter = BuildParams(filter);
        paramFilter.Add("countOutput", true);
        return await Core.SendRequestAsync<int>(paramFilter, ClassName + ".get");
    }

    public async Task<Dictionary<string, TEntity>> PreserveKeysAsync(TEntityFilter? filter = null)
    {
        var paramFilter = BuildParams(filter);
        paramFilter.Add("preservekeys", true);
        return await Core.SendRequestAsync<Dictionary<string, TEntity>>(paramFilter, ClassName + ".get");
    }

}
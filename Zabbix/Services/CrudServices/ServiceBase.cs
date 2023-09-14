using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public abstract class ServiceBase
{
    protected string ClassName;
    protected ICore Core;

    protected ServiceBase(ICore core, string className)
    {
        Core = core;
        ClassName = className;
    }

    protected virtual Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        var json = JsonConvert.SerializeObject(filter, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        });
        var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

        return dictionary != null ? new Dictionary<string, object>(dictionary) : new Dictionary<string, object>();
    }

}
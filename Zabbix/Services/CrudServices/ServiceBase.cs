using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices;

public abstract class ServiceBase
{
    protected string ClassName;
    protected ICore Core;
    protected JsonSerializerSettings SerializerSettings;

    protected ServiceBase(ICore core, string className)
    {
        Core = core;
        ClassName = className;
        SerializerSettings = new JsonSerializerSettings {
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new List<JsonConverter>() { new ZabbixQueryConverter() }
        };
    }

    protected virtual Dictionary<string, object> BuildParams(FilterOptions? filter = null)
    {
        var json = JsonConvert.SerializeObject(filter, SerializerSettings);
        var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

        return dictionary ?? new Dictionary<string, object>();
    }



}
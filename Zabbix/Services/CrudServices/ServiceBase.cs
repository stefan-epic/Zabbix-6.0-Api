using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Filter;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference_commentary#common-get-method-parameters
public abstract class ServiceBase
{
    protected string ClassName;
    protected ICore Core;

    protected ServiceBase(ICore core, string className)
    {
        Core = core;
        ClassName = className;
    }

    protected abstract Dictionary<string, object> BuildParams(FilterOptions? filter = null);



    //TODO make this default implementation of BuildParams
    protected Dictionary<string, object> BaseBuildParams(FilterOptions? filter = null)
    {

        string json = JsonConvert.SerializeObject(filter, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        });
        var dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

        if (dictionary != null)
        {
            return new Dictionary<string, object>(dictionary);
        }

        return new Dictionary<string, object>();
    }
}
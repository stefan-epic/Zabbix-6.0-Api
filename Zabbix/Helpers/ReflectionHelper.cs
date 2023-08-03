using System.Reflection;
using Newtonsoft.Json;

namespace Zabbix.Helpers;

public class ReflectionHelper<TEntity>
{
    public List<string> GetJsonPropertiesOfEntity()
    {
        List<string> jsonProperties = new List<string>();

        Type entityType = typeof(TEntity);
        PropertyInfo[] properties = entityType.GetProperties();

        foreach (PropertyInfo propertyInfo in properties)
        {
            JsonPropertyAttribute jsonPropertyAttribute = propertyInfo.GetCustomAttribute<JsonPropertyAttribute>();
            if (jsonPropertyAttribute != null) jsonProperties.Add(jsonPropertyAttribute.PropertyName);
        }

        return jsonProperties;
    }
}
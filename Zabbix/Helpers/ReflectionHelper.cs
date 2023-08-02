using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Helpers
{
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
                if (jsonPropertyAttribute != null)
                {
                    jsonProperties.Add(jsonPropertyAttribute.PropertyName);
                }
            }

            return jsonProperties;
        }
    }
}

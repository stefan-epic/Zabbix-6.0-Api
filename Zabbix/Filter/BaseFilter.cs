using System;
using System.Collections.Generic;

namespace Zabbix.Filter
{
    public abstract class BaseFilter<TEnum> where TEnum : Enum
    {
        public Dictionary<string, List<object>> Filter { get; }

        public BaseFilter()
        {
            Filter = new Dictionary<string, List<object>>();
        }
        public BaseFilter(Dictionary<string, List<object>> filter)
        {
            Filter = filter;
        }

        public bool IsNullOrEmpty()
        {
            if (Filter == null || Filter.Count == 0)
                return true;
            return false;
        }

        public void AddOrReplaceProperty(TEnum name, object value)
        {
            Filter[name.ToString()] = new List<object> { value };
        }

        public void AddIfNotExistsProperty(TEnum name, object value)
        {
            if (!Filter.ContainsKey(name.ToString()))
            {
                Filter[name.ToString()] = new List<object> { value };
            }
        }

        public void AddObjectToProperty(TEnum name, object value)
        {
            if (Filter.ContainsKey(name.ToString()))
            {
                Filter[name.ToString()].Add(value);
            }
            else
            {
                AddOrReplaceProperty(name, value);
            }
        }
    }
}

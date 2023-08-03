namespace Zabbix.Filter;

public abstract class BaseFilter<TEnum> where TEnum : Enum
{
    public BaseFilter()
    {
        Filter = new Dictionary<string, List<object>>();
    }

    public BaseFilter(Dictionary<string, List<object>> filter)
    {
        Filter = filter;
    }

    public Dictionary<string, List<object>> Filter { get; }

    public bool IsNullOrEmpty()
    {
        if (Filter == null || Filter.Count == 0)
            return true;
        return false;
    }

    public void Set(TEnum name, object value)
    {
        Filter[name.ToString()] = new List<object> { value };
    }

    public void SetIfNotExists(TEnum name, object value)
    {
        if (!Filter.ContainsKey(name.ToString())) Filter[name.ToString()] = new List<object> { value };
    }

    public void Append(TEnum name, object value)
    {
        if (Filter.ContainsKey(name.ToString()))
            Filter[name.ToString()].Add(value);
        else
            Set(name, value);
    }
}
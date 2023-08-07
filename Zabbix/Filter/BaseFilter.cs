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

    public bool IsEmpty()
    {
        return Filter.Count == 0;
    }

    public virtual void Set(TEnum name, object value)
    {
        Filter[name.ToString()] = new List<object> { value };
    }

    public virtual void SetIfNotExists(TEnum name, object value)
    {
        if (!Filter.ContainsKey(name.ToString())) Filter[name.ToString()] = new List<object> { value };
    }

    public virtual void Append(TEnum name, object value)
    {
        if (Filter.ContainsKey(name.ToString()))
            Filter[name.ToString()].Add(value);
        else
            Set(name, value);
    }
}
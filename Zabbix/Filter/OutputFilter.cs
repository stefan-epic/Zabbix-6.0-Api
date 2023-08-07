namespace Zabbix.Filter;

public class OutputFilter<TEntityProperty> where TEntityProperty : Enum
{
    public OutputFilter(List<string> filter)
    {
        Filter = filter;
    }

    public OutputFilter()
    {
        Filter = new List<string>();
    }

    public List<string> Filter { get; set; }

    public bool IsEmpty()
    {
        return Filter.Count == 0;
    }

    public void AddFilter(TEntityProperty filter)
    {
        if (!string.IsNullOrEmpty(filter.ToString())) Filter.Add(filter.ToString());
    }
}
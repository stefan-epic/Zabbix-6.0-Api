namespace Zabbix.Filter;

public class IncludeFilter<TEntityInclude> : BaseFilter<TEntityInclude> where TEntityInclude : Enum
{
    public IncludeFilter()
    {
    }


    public IncludeFilter(Dictionary<string, List<object>> filter) : base(filter)
    {
    }
}
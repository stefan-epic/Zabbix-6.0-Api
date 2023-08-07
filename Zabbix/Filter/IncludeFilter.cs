namespace Zabbix.Filter;

public class IncludeFilter<TEntityInclude> : BaseFilter<TEntityInclude> where TEntityInclude : Enum
{
    public IncludeFilter()
    {
    }

    public override void Set(TEntityInclude name, object? value = null)
    {
        if (value == null)
            value = "extend";
        base.Set(name, value);
    }


    public IncludeFilter(Dictionary<string, List<object>> filter) : base(filter)
    {
    }
}
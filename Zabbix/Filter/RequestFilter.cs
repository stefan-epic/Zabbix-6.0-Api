namespace Zabbix.Filter;

public class RequestFilter<TEntityProperty, TEntityInclude>
    where TEntityProperty : Enum
    where TEntityInclude : Enum
{
    public RequestFilter()
    {
        OutputFilter = new OutputFilter<TEntityProperty>();
        ObjectFilter = new ObjectFilter<TEntityProperty>();
        IncludeFilter = new IncludeFilter<TEntityInclude>();
    }

    public RequestFilter(OutputFilter<TEntityProperty> outputFilter,
        ObjectFilter<TEntityProperty> objectFilter, IncludeFilter<TEntityInclude> includeFilter)
    {
        OutputFilter = outputFilter;
        ObjectFilter = objectFilter;
        IncludeFilter = includeFilter;
    }

    public OutputFilter<TEntityProperty> OutputFilter { get; set; }
    public ObjectFilter<TEntityProperty> ObjectFilter { get; set; }
    public IncludeFilter<TEntityInclude> IncludeFilter { get; set; }

    public bool IsOutputFilterEmpty()
    {
        return OutputFilter.IsEmpty();
    }

    public bool IsObjectFilterEmpty()
    {
        return ObjectFilter.IsEmpty();
    }

    public bool IsIncludeFilterEmpty()
    {
        return IncludeFilter.IsEmpty();
    }
}
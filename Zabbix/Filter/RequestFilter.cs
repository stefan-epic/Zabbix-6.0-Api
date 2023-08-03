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

    public RequestFilter(OutputFilter<TEntityProperty> outputFilter = null,
        ObjectFilter<TEntityProperty> objectFilter = null, IncludeFilter<TEntityInclude> includeFilter = null)
    {
        OutputFilter = outputFilter;
        ObjectFilter = objectFilter;
        IncludeFilter = includeFilter;
    }

    public OutputFilter<TEntityProperty> OutputFilter { get; set; }
    public ObjectFilter<TEntityProperty> ObjectFilter { get; set; }
    public IncludeFilter<TEntityInclude> IncludeFilter { get; set; }

    public bool IsOutputFilterNullOrEmpty()
    {
        if (OutputFilter == null || OutputFilter.IsNullOrEmpty())
            return true;
        return false;
    }

    public bool IsObjectFilterNullOrEmpty()
    {
        if (ObjectFilter == null || ObjectFilter.IsNullOrEmpty())
            return true;
        return false;
    }

    public bool IsIncludeFilterNullOrEmpty()
    {
        if (IncludeFilter == null || IncludeFilter.IsNullOrEmpty())
            return true;
        return false;
    }
}
﻿using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using ZabbixApi.Helper;

namespace Zabbix.Services.CrudServices;

//https://www.zabbix.com/documentation/6.0/en/manual/api/reference_commentary#common-get-method-parameters
public abstract class ServiceBase<TEntity, TEntityInclude, TEntityProperty>
    where TEntity : BaseEntitiy
    where TEntityInclude : struct, Enum
    where TEntityProperty : Enum
{
    protected string ClassName;
    protected ICore Core;

    protected ServiceBase(ICore core, string className)
    {
        Core = core;
        ClassName = className;
    }

    protected abstract Dictionary<string, object> BuildParams(
        RequestFilter<TEntityProperty, TEntityInclude> filter = null, Dictionary<string, object> @params = null);



    protected Dictionary<string, object> MapIncludesToParams(IncludeFilter<TEntityInclude> include,
        Dictionary<string, object> @params)
    {
        foreach (KeyValuePair<string, List<object>> kvp in include.Filter) @params.Add(kvp.Key, kvp.Value);
        return @params;
    }

    //TODO make this default implementation
    protected Dictionary<string, object> BaseBuildParams(RequestFilter<TEntityProperty, TEntityInclude> filter = null,
        Dictionary<string, object> @params = null)
    {
        if (@params == null)
            @params = new Dictionary<string, object>();

        if (filter != null)
        {
            if (!filter.IsOutputFilterNullOrEmpty())
                @params.Add("output", filter.OutputFilter.Filter);
            else
                @params.AddIfNotExist("output", "extend");


            if (!filter.IsIncludeFilterNullOrEmpty())
                @params = MapIncludesToParams(filter.IncludeFilter, @params);
            if (!filter.IsObjectFilterNullOrEmpty())
                @params.Add("filter", filter.ObjectFilter.Filter);
        }

        return @params;
    }
}
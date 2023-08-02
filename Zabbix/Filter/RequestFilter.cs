using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Services;

namespace Zabbix.Filter
{
    public class RequestFilter<TEntityProperty, TEntityInclude> where TEntityProperty : Enum where TEntityInclude : Enum
    {
        public OutputFilter<TEntityProperty> OutputFilter { get; set; }
        public ObjectFilter<TEntityProperty> ObjectFilter { get; set; }
        public IncludeFilter<TEntityInclude> IncludeFilter { get; set; }

        public RequestFilter()
        {
            OutputFilter = new OutputFilter<TEntityProperty>();
            ObjectFilter = new ObjectFilter<TEntityProperty>();
            IncludeFilter = new IncludeFilter<TEntityInclude>();

        }
        public RequestFilter(OutputFilter<TEntityProperty> outputFilter = null, ObjectFilter<TEntityProperty> objectFilter = null, IncludeFilter<TEntityInclude> includeFilter = null)
        {
            OutputFilter = outputFilter;
            ObjectFilter = objectFilter;
            IncludeFilter = includeFilter;
        }


    }
}

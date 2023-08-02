using ZabbixApi.Helper;

namespace Zabbix.Filter
{
    public class ObjectFilter<TEntityProperty> : BaseFilter<TEntityProperty> where TEntityProperty : Enum
    {
        public ObjectFilter() : base()
        {
        }

        public ObjectFilter(Dictionary<string, List<object>> filter) : base(filter)
        {
        }
    }


}

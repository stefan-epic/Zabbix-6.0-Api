namespace Zabbix.Filter
{
    public class OutputFilter<TEntityProperty> where TEntityProperty : Enum
    {
        public List<string> Filter { get; set; }

        public OutputFilter(List<string> filter)
        {
            Filter = filter;
        }
        public OutputFilter()
        {
            Filter = new();
        }
        public bool IsNullOrEmpty()
        {
            if (Filter == null || Filter.Count == 0)
                return true;
            return false;
        }
        public void AddFilter(TEntityProperty filter)
        {
            if (!string.IsNullOrEmpty(filter.ToString()))
            {
                Filter.Add(filter.ToString());
            }
        }

    }


}

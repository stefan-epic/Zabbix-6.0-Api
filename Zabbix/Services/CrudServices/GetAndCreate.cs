using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;

namespace Zabbix.Services.CrudServices
{
    //TODO
    public abstract class GetAndCreate<TEntity, TEntityFilter> : GetService<TEntity, TEntityFilter>, ICreate<TEntity> where TEntity : BaseEntity where TEntityFilter : GetFilter
    {
        public GetAndCreate(ICore core, string className) : base(core, className)
        {
        }

        public IEnumerable<string> Create(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public string Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

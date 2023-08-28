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
    public abstract class GetAndCreate<TEntity, TEntityInclude, TEntityProperty> : GetService<TEntity, TEntityInclude, TEntityProperty>, ICreate<TEntity> where TEntityProperty : Enum where TEntityInclude : struct, Enum where TEntity : BaseEntity
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

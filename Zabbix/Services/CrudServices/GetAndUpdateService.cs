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
    public class GetAndUpdateService<TEntity, TEntityInclude, TEntityProperty> : GetService<TEntity, TEntityInclude,TEntityProperty>, IUpdate<TEntity>
        where TEntity : BaseEntitiy
        where TEntityInclude : struct, Enum
        where TEntityProperty : Enum
    {
        public GetAndUpdateService(ICore core, string className) : base(core, className)
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<TEntityProperty, TEntityInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }


        //TODO:
        public IEnumerable<string> Update(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public string Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<string>> UpdateAsync(IEnumerable<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices
{
    public interface ICreateService<TEntity, TEntityResult> where TEntity : BaseEntity where TEntityResult : BaseResult
    {
        IEnumerable<string> Create(IEnumerable<TEntity> entities);
        string Create(TEntity entity);
        Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entities);
        Task<string> CreateAsync(TEntity entity);
    }

    public class CreateService<TEntity, TEntityResult> : ServiceBase, ICreateService<TEntity, TEntityResult> where TEntity : BaseEntity
    where TEntityResult : BaseResult
    {

        public CreateService(ICore core, string className) : base(core, className) { }

        #region Create

        public virtual IEnumerable<string> Create(IEnumerable<TEntity> entities)
        {
            var ret = Core.SendRequest<TEntityResult>(entities, ClassName + ".create").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public virtual string Create(TEntity entity)
        {
            var ret = Create(new List<TEntity> { entity }).FirstOrDefault();
            return Checker.ReturnEmptyStringOrActual(ret);
        }

        public virtual async Task<IEnumerable<string>> CreateAsync(IEnumerable<TEntity> entities)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(entities, ClassName + ".create")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public virtual async Task<string> CreateAsync(TEntity entity)
        {
            var ret = (await CreateAsync(new List<TEntity> { entity })).FirstOrDefault();
            return Checker.ReturnEmptyStringOrActual(ret);
        }

        #endregion


    }
}

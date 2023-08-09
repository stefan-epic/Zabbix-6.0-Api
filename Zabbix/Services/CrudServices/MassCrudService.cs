using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Helpers;

//Host HostGroup Hostinterface, Template
namespace Zabbix.Services.CrudServices
{
    public interface IMassAdd<TEntity> where TEntity : BaseEntitiy
    {
        public IList<string> MassAdd(IEnumerable<TEntity> entities, TEntity updatedEntity);
        public Task<IList<string>> MassAddAsync(IEnumerable<TEntity> entities, TEntity updatedEntity);
    }
    public interface IMassRemove<TEntity> where TEntity : BaseEntitiy
    {
        public IList<string> MassRemove(IEnumerable<TEntity> entities, TEntity updatedEntity);
        public Task<IList<string>> MassRemoveAsync(IEnumerable<TEntity> entities, TEntity updatedEntity);
    }
    public interface IMassUpdate<TEntity> where TEntity : BaseEntitiy
    {
        public IList<string> MassUpdate(IEnumerable<TEntity> entities, TEntity updatedEntity);
        public Task<IList<string>> MassUpdateAsync(IEnumerable<TEntity> entities, TEntity updatedEntity);
    }

    public abstract class MassCrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> : 
        CrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> , IMassAdd<TEntity>, IMassRemove<TEntity>, IMassUpdate<TEntity>
            where TEntity : BaseEntitiy 
            where TEntityInclude : struct, Enum 
            where TEntityProperty : Enum 
            where TEntityResult : BaseResult
    {
        public MassCrudService(ICore core, string className) : base(core, className)
        {
        }

        #region MassAdd

        public IList<string> MassAdd(IEnumerable<TEntity> entities, TEntity updatedEntity)
        {
            var ret = Core.SendRequest<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massadd").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IList<string>> MassAddAsync(IEnumerable<TEntity> entities, TEntity updatedEntity)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massadd")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion

        #region MassUpdate

        public IList<string> MassUpdate(IEnumerable<TEntity> entities, TEntity updatedEntity)
        {
            var ret = Core.SendRequest<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massupdate").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IList<string>> MassUpdateAsync(IEnumerable<TEntity> entities, TEntity updatedEntity)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massupdate")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }


        #endregion

        #region MassRemove

        public IList<string> MassRemove(IEnumerable<TEntity> entities, TEntity updatedEntity)
        {
            var ret = Core.SendRequest<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massremove").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IList<string>> MassRemoveAsync(IEnumerable<TEntity> entities, TEntity updatedEntity)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massremove")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion


        public abstract Dictionary<string, object> BuildMassParams(IEnumerable<TEntity> entities, TEntity properties, Dictionary<string, object>? @params = null);

    }
}

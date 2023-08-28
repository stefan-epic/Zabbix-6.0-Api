//Host HostGroup Hostinterface, Template
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Helpers;

namespace Zabbix.Services.CrudServices
{
    public interface IMassAdd<TEntity, TEntityProperty> where TEntity : BaseEntity where TEntityProperty : Enum
    {
        public IList<string> MassAdd(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity);
        public Task<IList<string>> MassAddAsync(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity);
    }
    public interface IMassRemove<TEntity, TEntityProperty> where TEntity : BaseEntity where TEntityProperty : Enum
    {
        public IList<string> MassRemove(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity);
        public Task<IList<string>> MassRemoveAsync(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity);
    }
    public interface IMassUpdate<TEntity, TEntityProperty> where TEntity : BaseEntity where TEntityProperty : Enum
    {
        public IList<string> MassUpdate(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity);
        public Task<IList<string>> MassUpdateAsync(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity);
    }

    public abstract class MassCrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult> :
        CrudService<TEntity, TEntityInclude, TEntityProperty, TEntityResult>, IMassAdd<TEntity, TEntityProperty>, IMassRemove<TEntity, TEntityProperty>, IMassUpdate<TEntity, TEntityProperty>
            where TEntity : BaseEntity
            where TEntityInclude : struct, Enum
            where TEntityProperty : Enum
            where TEntityResult : BaseResult
    {
        public MassCrudService(ICore core, string className) : base(core, className)
        {
        }

        #region MassAdd

        public IList<string> MassAdd(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity)
        {
            var ret = Core.SendRequest<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massadd").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IList<string>> MassAddAsync(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massadd")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion

        #region MassUpdate

        public IList<string> MassUpdate(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity)
        {
            var ret = Core.SendRequest<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massupdate").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IList<string>> MassUpdateAsync(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massupdate")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }


        #endregion

        #region MassRemove

        public IList<string> MassRemove(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity)
        {
            var ret = Core.SendRequest<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massremove").Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        public async Task<IList<string>> MassRemoveAsync(IEnumerable<TEntity> entities, Dictionary<TEntityProperty, object> updatedEntity)
        {
            var ret = (await Core.SendRequestAsync<TEntityResult>(BuildMassParams(entities, updatedEntity), ".massremove")).Ids;
            return Checker.ReturnEmptyListOrActual(ret);
        }

        #endregion


        public abstract Dictionary<string, object> BuildMassParams(IEnumerable<TEntity> entities,
            Dictionary<TEntityProperty, object> properties, Dictionary<string, object>? @params = null);

    }
}
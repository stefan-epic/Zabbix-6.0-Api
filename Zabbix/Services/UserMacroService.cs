using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;
 
public class UserMacroService : CrudService<UserMacro, UserMacroFilterOptions, UserMacroService.UserMacroResult>
{
    public UserMacroService(ICore core) : base(core, "usermacro")
    {
    }


    public class UserMacroResult : BaseResult
    {
        [JsonProperty("hostmacroids")] public override IList<string>? Ids { get; set; }
    }
    public class GlobalMacroResult : BaseResult
    {
        [JsonProperty("globalmacroids")] public override IList<string>? Ids { get; set; }
    }
    public string CreateGlobal(GlobalMacro macro)
    {
        var ids = CreateGlobal(new List<GlobalMacro>() { macro }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }
    public string UpdateGlobal(GlobalMacro macro)
    {
        var ids = UpdateGlobal(new List<GlobalMacro>() { macro }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }
    public string DeleteGlobal(GlobalMacro macro)
    {
        var ids = DeleteGlobal(new List<GlobalMacro>() { macro }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }
    public string DeleteGlobal(string id)
    {
        var ids = DeleteGlobal(new List<string>() { id }).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }

    public async Task<string> CreateGlobalAsync(GlobalMacro macro)
    {
        var ids = (await CreateGlobalAsync(new List<GlobalMacro>() { macro })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }
    public async Task<string> UpdateGlobalAsync(GlobalMacro macro)
    {
        Checker.CheckEntityId(macro);
        var ids = (await UpdateGlobalAsync(new List<GlobalMacro>() { macro })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }
    public async Task<string> DeleteGlobalAsync(GlobalMacro macro)
    {
        Checker.CheckEntityId(macro);
        var ids = (await DeleteGlobalAsync(new List<GlobalMacro>() { macro })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }
    public async Task<string> DeleteGlobalAsync(string id)
    {
        var ids = (await DeleteGlobalAsync(new List<string>() { id })).FirstOrDefault();
        return Checker.ReturnEmptyStringOrActual(ids);
    }


    public IEnumerable<string> CreateGlobal(IEnumerable<GlobalMacro> macros)
    {
        var ids = Core.SendRequest<GlobalMacroResult>(macros, "usermacro.createglobal").Ids;
        return Checker.ReturnEmptyListOrActual(ids);
    }
    public IEnumerable<string> UpdateGlobal(IEnumerable<GlobalMacro> macros)
    {
        Checker.CheckEntityIds(macros);
        var ids = Core.SendRequest<GlobalMacroResult>(macros, "usermacro.updateglobal").Ids;
        return Checker.ReturnEmptyListOrActual(ids);
    }
    public IEnumerable<string> DeleteGlobal(IEnumerable<GlobalMacro> macros)
    {
        var globalMacros = macros.ToList();
        Checker.CheckEntityIds(globalMacros);
        var toDelete = globalMacros.Select(globalMacro => globalMacro.EntityId);
        var ids = Core.SendRequest<GlobalMacroResult>(macros, "usermacro.updateglobal").Ids;
        return Checker.ReturnEmptyListOrActual(ids);
    }
    public IEnumerable<string> DeleteGlobal(IEnumerable<string> ids)
    {
        var deleted = Core.SendRequest<GlobalMacroResult>(ids, "usermacro.updateglobal").Ids;
        return Checker.ReturnEmptyListOrActual(deleted);
    }

    public async Task<IEnumerable<string>> CreateGlobalAsync(IEnumerable<GlobalMacro> macros)
    {
        var ids = (await Core.SendRequestAsync<GlobalMacroResult>(macros, "usermacro.createglobal")).Ids;
        return Checker.ReturnEmptyListOrActual(ids);
    }
    public async Task<IEnumerable<string>> UpdateGlobalAsync(IEnumerable<GlobalMacro> macros)
    {
        Checker.CheckEntityIds(macros);
        var ids = (await Core.SendRequestAsync<GlobalMacroResult>(macros, "usermacro.updateglobal")).Ids;
        return Checker.ReturnEmptyListOrActual(ids);
    }
    public async Task<IEnumerable<string>> DeleteGlobalAsync(IEnumerable<GlobalMacro> macros)
    {
        var globalMacros = macros.ToList();
        Checker.CheckEntityIds(globalMacros);
        var toDelete = globalMacros.Select(globalMacro => globalMacro.EntityId);
        var ids = (await Core.SendRequestAsync<GlobalMacroResult>(toDelete, "usermacro.updateglobal")).Ids;
        return Checker.ReturnEmptyListOrActual(ids);
    }
    public async Task<IEnumerable<string>> DeleteGlobalAsync(IEnumerable<string> ids)
    {
        var deleted = (await Core.SendRequestAsync<GlobalMacroResult>(ids, "usermacro.updateglobal")).Ids;
        return Checker.ReturnEmptyListOrActual(deleted);
    }
}

public class UserMacroFilterOptions : FilterOptions
{
    [JsonProperty("globalmacro")] public bool? GlobalMacro { get; set; }

    [JsonProperty("globalmacroids")] public object? GlobalMacroIds { get; set; }

    [JsonProperty("groupids")] public object? GroupIds { get; set; }

    [JsonProperty("hostids")] public object? HostIds { get; set; }

    [JsonProperty("hostmacroids")] public object? HostMacroIds { get; set; }

    [JsonProperty("inherited")] public bool? Inherited { get; set; }

    [JsonProperty("selectGroups")] public object? SelectGroups { get; set; }

    [JsonProperty("selectHosts")] public object? SelectHosts { get; set; }

    [JsonProperty("selectTemplates")] public object? SelectTemplates { get; set; }
}
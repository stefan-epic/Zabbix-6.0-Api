using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class AlertService : GetService<Alert, AlertFilterOptions>
{
    public AlertService(ICore core) : base(core, "alert")
    {
    }

}

public class AlertFilterOptions : FilterOptions
{
    #region Filter Properties

    [JsonProperty("alertids")]
    public object? AlertIds { get; set; }

    [JsonProperty("actionids")]
    public object? ActionIds { get; set; }

    [JsonProperty("eventids")]
    public object? EventIds { get; set; }

    [JsonProperty("groupids")]
    public object? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public object? HostIds { get; set; }

    [JsonProperty("mediatypeids")]
    public object? MediaTypeIds { get; set; }

    [JsonProperty("objectids")]
    public object? ObjectIds { get; set; }

    [JsonProperty("userids")]
    public object? UserIds { get; set; }

    [JsonProperty("eventobject")]
    public int? EventObject { get; set; }

    [JsonProperty("eventsource")]
    public int? EventSource { get; set; }

    [JsonProperty("time_from")]
    public DateTime? TimeFrom { get; set; }

    [JsonProperty("time_till")]
    public DateTime? TimeTill { get; set; }

    [JsonProperty("selectHosts")]
    public object? SelectHosts { get; set; }

    [JsonProperty("selectMediatypes")]
    public object? SelectMediatypes { get; set; }

    [JsonProperty("selectUsers")]
    public object? SelectUsers { get; set; }

    #endregion
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services;

public class AlertService : GetService<Alert, GetAlertFilter>
{
    public AlertService(ICore core) : base(core, "alert")
    {
    }

    protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
    {
        return BaseBuildParams(filter);
    }
}

public class GetAlertFilter : GetFilter
{
    #region Filter Properties

    [JsonProperty("alertids")]
    public IList<string>? AlertIds { get; set; }

    [JsonProperty("actionids")]
    public IList<string>? ActionIds { get; set; }

    [JsonProperty("eventids")]
    public IList<string>? EventIds { get; set; }

    [JsonProperty("groupids")]
    public IList<string>? GroupIds { get; set; }

    [JsonProperty("hostids")]
    public IList<string>? HostIds { get; set; }

    [JsonProperty("mediatypeids")]
    public IList<string>? MediaTypeIds { get; set; }

    [JsonProperty("objectids")]
    public IList<string>? ObjectIds { get; set; }

    [JsonProperty("userids")]
    public IList<string>? UserIds { get; set; }

    [JsonProperty("eventobject")]
    public int? EventObject { get; set; }

    [JsonProperty("eventsource")]
    public int? EventSource { get; set; }

    [JsonProperty("time_from")]
    public DateTime? TimeFrom { get; set; }

    [JsonProperty("time_till")]
    public DateTime? TimeTill { get; set; }

    [JsonProperty("selectHosts")]
    public IList<string>? SelectHosts { get; set; }

    [JsonProperty("selectMediatypes")]
    public IList<string>? SelectMediatypes { get; set; }

    [JsonProperty("selectUsers")]
    public IList<string>? SelectUsers { get; set; }

    #endregion
}

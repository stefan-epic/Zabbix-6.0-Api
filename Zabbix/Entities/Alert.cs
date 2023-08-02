using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum AlertProperties
    {
        alertid,
        actionid,
        eventid,
        userid,
        clock,
        mediatypeid,
        sendto,
        subject,
        message,
        status,
        retries,
        error,
        esc_step,
        alerttype,
        p_eventid,
        acknowledgeid
    }

    public class Alert : BaseEntitiy
    {
        #region Properties

        [JsonProperty("alertid")] public string Alertid { get; set; }

        [JsonProperty("actionid")] public string Actionid { get; set; }

        [JsonProperty("eventid")] public string Eventid { get; set; }

        [JsonProperty("userid")] public string Userid { get; set; }

        [JsonProperty("clock")] public string Clock { get; set; }

        [JsonProperty("mediatypeid")] public string Mediatypeid { get; set; }

        [JsonProperty("sendto")] public string Sendto { get; set; }

        [JsonProperty("subject")] public string Subject { get; set; }

        [JsonProperty("message")] public string Message { get; set; }

        [JsonProperty("status")] public string Status { get; set; }

        [JsonProperty("retries")] public string Retries { get; set; }

        [JsonProperty("error")] public string Error { get; set; }

        [JsonProperty("esc_step")] public string EscStep { get; set; }

        [JsonProperty("alerttype")] public string Alerttype { get; set; }

        [JsonProperty("p_eventid")] public string PEventid { get; set; }

        [JsonProperty("acknowledgeid")] public string Acknowledgeid { get; set; }

        #endregion

        #region Components

        List<Host> Hosts { get; set; }
        List<MediaType> MediaTypes { get; set; }
        List<User> Users { get; set; }

        #endregion
    }
}
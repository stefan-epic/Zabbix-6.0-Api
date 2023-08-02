using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class EventService : GetService<Event, EventInclude, EventProperties>
    {
        public EventService(ICore core) : base(core, "event")
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<EventProperties, EventInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        
        //TODO: make enum for action, make async variants
        public IEnumerable<string> Acknowledge(IList<string> eventIds, int action, string message = null, string severity = null)
        {
            Dictionary<string, object> @params = new()
            {
                { "eventids", eventIds },
                { "action", action }
            };

            if (message != null)
                @params.Add("message", message);
            if(severity != null)
                @params.Add("severity", severity);


            return Core.SendRequest<EventResult>(@params, ClassName + ".acknowledge").Ids;
        }
        public class EventResult : BaseResult
        {
            public override string[] Ids { get; set; }
        }
    }

    public enum EventInclude
    {
        selectHosts,
        selectRelatedObject,
        selectAlerts,
        selectAcknowledges,
        selectTags,
        selectSuppressionData
    }
}

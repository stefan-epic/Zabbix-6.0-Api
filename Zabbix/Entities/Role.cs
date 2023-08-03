using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum RoleProperties
    {
    }
    public class Role : BaseEntitiy
    {
        #region Properties
        [JsonProperty("roleid")]
        public override string EntityId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("readonly")]
        public string ReadOnly { get; set; }
        #endregion

        #region Components
        [JsonProperty("rules")]
        public IList<RoleRule> Rules { get; set; }

        #endregion

    }


    public class RoleRule
    {
        #region Properties

        [JsonProperty("ui.default_access")]
        public string UiDefaultAccess { get; set; }

        [JsonProperty("services.read.mode")]
        public string ServicesReadMode { get; set; }

        [JsonProperty("services.read.tag")]
        public IList<Tag> ServicesReadTag { get; set; }

        [JsonProperty("services.write.mode")]
        public string ServicesWriteMode { get; set; }
        
        [JsonProperty("modules.default_access")]
        public string ModulesDefaultAccess { get; set; }

        [JsonProperty("api.access")]
        public string ApiAccess { get; set; }

        [JsonProperty("api.mode")]
        public string ApiMode { get; set; }

        [JsonProperty("api")]
        public IList<string> Api { get; set; }

        [JsonProperty("actions.default_access")]
        public string ActionsDefaultAccess { get; set; }

        #endregion

        #region Components
        [JsonProperty("ui")]
        public IList<UiElement> Ui { get; set; }

        [JsonProperty("services.read.list")]
        public IList<RoleRuleService> ServicesReadList { get; set; }

        [JsonProperty("services.write.list")]
        public IList<RoleRuleService> ServicesWriteList { get; set; }

        [JsonProperty("services.write.tag")]
        public IList<Tag> ServicesWriteTag { get; set; }

        [JsonProperty("modules")]
        public IList<Module> Modules { get; set; }

        [JsonProperty("actions")]
        public IList<RoleAction> Actions { get; set; }

        #endregion
    }


    public class RoleRuleService
    {
        #region Properties

        [JsonProperty("serviceid")]
        public string ServiceId { get; set; }

        #endregion

    }
    public class Module
    {
        #region Properties

        [JsonProperty("moduleid")]
        public string ModuleId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        #endregion

    }

    public class UiElement
    {
        #region Properties

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion

    }
    public class RoleAction
    {
        #region Properties

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

        #endregion

    }
}

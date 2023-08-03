﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    //https://www.zabbix.com/documentation/6.0/en/manual/api/reference/usermacro/get
    //TODO: Global functions
    public class UserMacroService : CrudService<UserMacro, UserMacroInclude, UserMacroProperties, UserMacroService.UserMacroResult>
    {

        public UserMacroService(ICore core, string className) : base(core, className)
        {
        }

        protected override Dictionary<string, object> BuildParams(RequestFilter<UserMacroProperties, UserMacroInclude> filter = null, Dictionary<string, object> @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class UserMacroResult : BaseResult
        {
            [JsonProperty("hostmacroids")]
            public override string[] Ids { get; set; }
        }

    }

    public enum UserMacroInclude
    {
        selectGroups,
        selectHosts,
        selectTemplates
    }
}

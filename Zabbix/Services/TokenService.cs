using System;
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
    public class TokenService : CrudService<Token, TokenInclude, TokenProperties, TokenService.TokenResult>
    {

        //TODO: Token generate token update methds
        public TokenService(ICore core) : base(core, "token")
        {
        }

        protected override Dictionary<string, object>? BuildParams(RequestFilter<TokenProperties, TokenInclude>? filter = null, Dictionary<string, object>? @params = null)
        {
            return BaseBuildParams(filter, @params);
        }
        public class TokenResult : BaseResult
        {
            [JsonProperty("tokenids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public enum TokenInclude
    {
    }
}

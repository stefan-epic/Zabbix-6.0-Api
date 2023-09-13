using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TokenService : CrudService<Token, GetTokenFilter, TokenService.TokenResult>
    {

        //TODO: Token generate token update methds
        public TokenService(ICore core) : base(core, "token")
        {
        }

        protected override Dictionary<string, object> BuildParams(GetFilter? filter = null)
        {
            return BaseBuildParams(filter);
        }
        public class TokenResult : BaseResult
        {
            [JsonProperty("tokenids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class GetTokenFilter : GetFilter
    {
        [JsonProperty("tokenids")]
        public IList<string>? TokenIds { get; set; }

        [JsonProperty("userids")]
        public IList<string>? UserIds { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("valid_at")]
        public string? ValidAt { get; set; }

        [JsonProperty("expired_at")]
        public string? ExpiredAt { get; set; }
    }

    public enum TokenInclude
    {
    }
}

using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TokenService : CrudService<Token, TokenFilterOptions, TokenService.TokenResult>
    {

        //TODO: Token generate token update methds
        public TokenService(ICore core) : base(core, "token")
        {
        }

        

        public class TokenResult : BaseResult
        {
            [JsonProperty("tokenids")]
            public override IList<string>? Ids { get; set; }
        }
    }

    public class TokenFilterOptions : FilterOptions
    {
        [JsonProperty("tokenids")]
        public object? TokenIds { get; set; }

        [JsonProperty("userids")]
        public object? UserIds { get; set; }

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

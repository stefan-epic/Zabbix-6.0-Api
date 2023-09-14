using Newtonsoft.Json;
using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services.CrudServices;

namespace Zabbix.Services
{
    public class TokenService : CrudService<Token, TokenFilterOptions, TokenService.TokenResult>
    {

        public TokenService(ICore core) : base(core, "token")
        {
        }

        public IEnumerable<TokenGenerateResult> Generate(IEnumerable<Token> tokens)
        {
            var baseEntities = tokens.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(token => token.EntityId!);
            return Core.SendRequest<IEnumerable<TokenGenerateResult>>(ids, "token.generate");
        }
        public async Task<IEnumerable<TokenGenerateResult>> GenerateAsync(IEnumerable<Token> tokens)
        {
            var baseEntities = tokens.ToList();
            Checker.CheckEntityIds(baseEntities);
            var ids = baseEntities.Select(token => token.EntityId!);
            return await Core.SendRequestAsync<IEnumerable<TokenGenerateResult>>(ids, "token.generate");
        }

        public IEnumerable<TokenGenerateResult> Generate(IEnumerable<string> tokenIds)
        {
            return Core.SendRequest<IEnumerable<TokenGenerateResult>>(tokenIds, "token.generate");
        }
        public async Task<IEnumerable<TokenGenerateResult>> GenerateAsync(IEnumerable<string> tokenIds)
        {
            return await Core.SendRequestAsync<IEnumerable<TokenGenerateResult>>(tokenIds, "token.generate");
        }

        public class TokenResult : BaseResult
        {
            [JsonProperty("tokenids")]
            public override IList<string>? Ids { get; set; }
        }
        public class TokenGenerateResult
        {
            [JsonProperty("tokenid")] public string? TokenId { get; set; }
            [JsonProperty("token")] public string? Token { get; set; }
        }
    }

    public class TokenFilterOptions : FilterOptions
    {
        [JsonProperty("tokenIds")]
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

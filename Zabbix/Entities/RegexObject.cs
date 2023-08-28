﻿using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public enum RegexObjectProperties
    {

    }
    public class RegexObject : BaseEntity
    {
        [JsonProperty("regexpid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("test_string")]
        public string? Teststring { get; set; }
    }
    public class Expressions
    {
        [JsonProperty("expression")]
        public string? Expression { get; set; }

        [JsonProperty("expression_type")]
        public int? ExpressionType { get; set; }

        [JsonProperty("exp_delimiter")]
        public string? ExpressionDelimiter { get; set; }

        [JsonProperty("case_sensitive")]
        public int? CaseSensitive { get; set; }
    }
}

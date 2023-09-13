using Newtonsoft.Json;

namespace Zabbix.Entities
{
    public class RegexObject : BaseEntity
    {
        #region Properties

        [JsonProperty("regexpid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("test_string")]
        public string? Teststring { get; set; }

        #endregion

        #region Constructors

        public RegexObject(string name)
        {
            Name = name;
        }

        public RegexObject() { }

        #endregion

    }
    public class Expressions
    {
        #region Properties

        [JsonProperty("expression")]
        public string? Expression { get; set; }

        [JsonProperty("expression_type")]
        public int? ExpressionType { get; set; }

        [JsonProperty("exp_delimiter")]
        public string? ExpressionDelimiter { get; set; }

        [JsonProperty("case_sensitive")]
        public int? CaseSensitive { get; set; }

        #endregion

        #region Constructors
        public Expressions(string expression, int expressionType)
        {
            Expression = expression;
            ExpressionType = expressionType;
        }

        public Expressions() { }

        #endregion

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum CorrelationProperties
    {

    }

    public class Correlation : BaseEntitiy
    {
        #region Properties

        [JsonProperty("correlationid")]
        public override string? EntityId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        #endregion

        #region Components

        [JsonProperty("operations")] public IList<CorrelationOperation>? Operations { get; set; }
        [JsonProperty("filter")] public IList<CorrelationFilter>? Filters { get; set; }

        #endregion
    }

}
public class CorrelationOperation
{
    #region Properties

    [JsonProperty("type")]
    public int? Type { get; set; }

    #endregion

}
public class CorrelationFilterCondition
{
    #region Properties

    [JsonProperty("type")]
    public int Type { get; set; }

    [JsonProperty("tag")]
    public string? Tag { get; set; }

    [JsonProperty("groupid")]
    public string? GroupId { get; set; }

    [JsonProperty("oldtag")]
    public string? OldTag { get; set; }

    [JsonProperty("newtag")]
    public string? NewTag { get; set; }

    [JsonProperty("value")]
    public string? Value { get; set; }

    [JsonProperty("formulaid")]
    public string? FormulaId { get; set; }

    [JsonProperty("operator")]
    public int? Operator { get; set; }

    #endregion

}

public class CorrelationFilter
{
    #region Properties
    [JsonProperty("evaltype")]
    public int EvalType { get; set; }

    [JsonProperty("conditions")]
    public IList<CorrelationFilterCondition>? Conditions { get; set; }

    [JsonProperty("eval_formula")]
    public string? EvalFormula { get; set; }

    [JsonProperty("formula")]
    public string? Formula { get; set; }

    #endregion

}
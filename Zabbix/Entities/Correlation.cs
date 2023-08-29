using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    //TODO:
    public enum CorrelationProperties
    {

    }

    public class Correlation : BaseEntity
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
        [JsonProperty("filter")] public CorrelationFilter? Filter { get; set; }

        #endregion

        #region Constructors

        public Correlation(IList<CorrelationOperation> operations, CorrelationFilter filter, string name)
        {
            Operations = operations;
            Filter = filter;
            Name = name;
        }

        public Correlation(){}

        #endregion
    }

}
public class CorrelationOperation
{
    #region Properties

    [JsonProperty("type")]
    public int? Type { get; set; }

    #endregion

    #region Constructors

    public CorrelationOperation(int type)
    {
        Type = type;
    }

    public CorrelationOperation()
    {

    }
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

    #region Constructors

    public CorrelationFilterCondition(int type)
    {
        Type = type;
    }

    public CorrelationFilterCondition()
    {

    }

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

    #region Constructors

    public CorrelationFilter(int evalType, IList<CorrelationFilterCondition> conditions)
    {
        EvalType = evalType;
        conditions = conditions;
    }

    public CorrelationFilter()
    {

    }

    #endregion
}
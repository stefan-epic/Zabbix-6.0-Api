using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum TriggerProperties
{
    triggerid,
    expression,
    description,
    url,
    status,
    value,
    priority,
    lastchange,
    comments,
    error,
    templateid,
    type,
    state,
    flags,
    recovery_mode,
    recovery_expression,
    correlation_mode,
    correlation_tag,
    manual_close
}
//TODO

public class TriggerFunction
{
    #region Properties

    [JsonProperty("functionid")] public string Functionid { get; set; }

    [JsonProperty("itemid")] public string Itemid { get; set; }

    [JsonProperty("triggerid")] public string Triggerid { get; set; }

    [JsonProperty("parameter")] public string Parameter { get; set; }

    [JsonProperty("function")] public string Function { get; set; }

    #endregion
}

public class Trigger : BaseEntitiy
{
    #region Components

    [JsonProperty("functions")] public List<Trigger> TriggerFunctions { get; set; }

    #endregion

    #region Properties

    [JsonProperty("triggerid")] public override string EntityId { get; set; }

    [JsonProperty("expression")] public string Expression { get; set; }

    [JsonProperty("description")] public string Description { get; set; }

    [JsonProperty("url")] public string Url { get; set; }

    [JsonProperty("status")] public string Status { get; set; }

    [JsonProperty("value")] public string Value { get; set; }

    [JsonProperty("priority")] public string Priority { get; set; }

    [JsonProperty("lastchange")] public string Lastchange { get; set; }

    [JsonProperty("comments")] public string Comments { get; set; }

    [JsonProperty("error")] public string Error { get; set; }

    [JsonProperty("templateid")] public string Templateid { get; set; }

    [JsonProperty("type")] public string Type { get; set; }

    [JsonProperty("state")] public string State { get; set; }

    [JsonProperty("flags")] public string Flags { get; set; }

    [JsonProperty("recovery_mode")] public string RecoveryMode { get; set; }

    [JsonProperty("recovery_expression")] public string RecoveryExpression { get; set; }

    [JsonProperty("correlation_mode")] public string CorrelationMode { get; set; }

    [JsonProperty("correlation_tag")] public string CorrelationTag { get; set; }

    [JsonProperty("manual_close")] public string ManualClose { get; set; }

    [JsonProperty("opdata")] public string Opdata { get; set; }

    #endregion

    #region Constructors

    public Trigger(string description, string expression)
    {
        Description = description;
        Expression = expression;
    }

    public Trigger()
    {
    }

    #endregion
}
using Newtonsoft.Json;

namespace Zabbix.Entities;
public enum ActionProperties
{
}
public class Action : BaseEntity
{
    #region Properties

    [JsonProperty("actionid")] public override string? EntityId { get; set; }

    [JsonProperty("esc_period")] public string? EscPeriod { get; set; }

    [JsonProperty("eventsource")] public int? EventSource { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("pause_suppressed")] public int? PauseSuppressed { get; set; }

    [JsonProperty("notify_if_canceled")] public int? NotifyIfCanceled { get; set; }

    #endregion

    #region Components

    [JsonProperty("filter")] public IList<ActionFilter>? Filters { get; set; }

    [JsonProperty("operations")] public IList<ActionOperation>? Operations { get; set; }

    [JsonProperty("recovery_operations")] public IList<ActionRecoveryOperation>? RecoveryOperations { get; set; }

    [JsonProperty("update_operations")] public IList<ActionUpdateOperation>? UpdateOperations { get; set; }

    #endregion

    #region Constructors

    public Action(string escPeriod, int eventSource, string name)
    {
        EscPeriod = escPeriod;
        EventSource = eventSource;
        Name = name;
    }

    public Action()
    {

    }

    #endregion

}

public class ActionOperation
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("operationtype")] public int? OperationType { get; set; }

    [JsonProperty("actionid")] public string? ActionId { get; set; }

    [JsonProperty("esc_period")] public int? EscPeriod { get; set; }

    [JsonProperty("esc_step_from")] public int? EscStepFrom { get; set; }

    [JsonProperty("esc_step_to")] public int? EscStepTo { get; set; }

    [JsonProperty("evaltype")] public string? EvalType { get; set; }

    [JsonProperty("opcommand")] public string? OpCommand { get; set; }

    #endregion

    #region Components

    [JsonProperty("opcommand_grp")] public IList<OperationCommandGroup>? OpCommandGroup { get; set; }

    [JsonProperty("opcommand_hst")] public IList<OperationCommandHost>? OpCommandHost { get; set; }

    [JsonProperty("opconditions")] public IList<OperationCondition>? OpConditions { get; set; }

    [JsonProperty("opgroup")] public IList<OperationGroup>? OpGroup { get; set; }

    [JsonProperty("opmessage")] public ActionOperationMessage? OpMessage { get; set; }

    [JsonProperty("opmessage_grp")] public IList<OperationMessageGroup>? OpMessageGroup { get; set; }

    [JsonProperty("opmessage_usr")] public IList<OperationMessageUser>? OpMessageUser { get; set; }

    [JsonProperty("filter")] public IList<ActionFilter>? Filter { get; set; }

    #endregion

    #region Constructors

    public ActionOperation(int operationType)
    {
        OperationType = operationType;
    }

    public ActionOperation()
    {

    }

    #endregion
}

public class ActionFilter
{
    #region Properties

    [JsonProperty("evaltype")] public int? Evaltype { get; set; }
    [JsonProperty("eval_formula")] public string? EvalFormula { get; set; }
    [JsonProperty("formula")] public string? Formula { get; set; }

    #endregion

    #region Components
    [JsonProperty("conditions")] public IList<ActionFilterCondition>? Conditions { get; set; }
    #endregion

    #region Constructors

    public ActionFilter(IList<ActionFilterCondition> conditions, int evalType)
    {
        Conditions = conditions;
        Evaltype = evalType;
    }

    public ActionFilter() { }

    #endregion
}

public class ActionFilterCondition
{
    #region Properties

    [JsonProperty("conditionid")] public string? ConditionId { get; set; }

    [JsonProperty("conditiontype")] public int? ConditionType { get; set; }

    [JsonProperty("value")] public string? Value { get; set; }

    [JsonProperty("value2")] public string? Value2 { get; set; }

    [JsonProperty("actionid")] public string? ActionId { get; set; }

    [JsonProperty("fomulaid")] public string? FormulaId { get; set; }

    [JsonProperty("operator")] public int? Operator { get; set; }

    #endregion

    #region Constructors

    public ActionFilterCondition(string value, int conditionType)
    {
        Value = value;
        ConditionType = conditionType;
    }
    public ActionFilterCondition(){}
    #endregion
}

public class ActionRecoveryOperation
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("operationtype")] public int? OperationType { get; set; }

    #endregion

    #region Components

    [JsonProperty("opcommand")] public OperationCommand? OpCommand { get; set; }

    [JsonProperty("opcommand_grp")] public IList<OperationCommandGroup>? OpCommandGroup { get; set; }

    [JsonProperty("opcommand_hst")] public IList<OperationCommandHost>? OpCommandHost { get; set; }

    [JsonProperty("opmessage")] public ActionOperationMessage? OpMessage { get; set; }

    [JsonProperty("opmessage_grp")] public IList<OperationMessageGroup>? OpMessageGroup { get; set; }

    [JsonProperty("opmessage_usr")] public IList<OperationMessageUser>? OpMessageUser { get; set; }

    #endregion

    #region Constructors

    public ActionRecoveryOperation(int operationType)
    {
        OperationType = operationType;
    }

    public ActionRecoveryOperation()
    {

    }
    

    #endregion
}

public class ActionUpdateOperation
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("operationtype")] public int? OperationType { get; set; }

    #endregion

    #region Components

    [JsonProperty("opcommand")] public OperationCommand? OpCommand { get; set; }

    [JsonProperty("opcommand_grp")] public IList<OperationCommandGroup>? OpCommandGroup { get; set; }

    [JsonProperty("opcommand_hst")] public IList<OperationCommandHost>? OpCommandHost { get; set; }

    [JsonProperty("opmessage")] public ActionOperationMessage? OpMessage { get; set; }

    [JsonProperty("opmessage_grp")] public IList<OperationMessageGroup>? OpMessageGroup { get; set; }

    [JsonProperty("opmessage_usr")] public IList<OperationMessageUser>? OpMessageUser { get; set; }

    #endregion

    #region Constructors

    public ActionUpdateOperation(int operationType)
    {
        OperationType = operationType;
    }

    public ActionUpdateOperation()
    {

    }


    #endregion
}

public class OperationCommand
{
    #region Properties

    [JsonProperty("scriptid")] public string? ScriptId { get; set; }

    #endregion
}

public class OperationGroup
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("groupid")] public string? GroupId { get; set; }

    #endregion
}

public class OperationCommandGroup
{
    #region Properties

    [JsonProperty("opcommand_grpid")] public string? OpCommandGroupId { get; set; }

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("groupid")] public string? GroupId { get; set; }

    #endregion
}

public class OperationCommandHost
{
    #region Properties

    [JsonProperty("opcommand_hstid")] public string? OpCommandHostId { get; set; }

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("hostid")] public string? HostId { get; set; }

    #endregion
}

public class OperationCondition
{
    #region MyRegion

    [JsonProperty("opconditionid")] public string? OpConditionId { get; set; }

    [JsonProperty("conditiontype")] public int? ConditionType { get; set; }

    [JsonProperty("value")] public string? Value { get; set; }

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("operator")] public int? Operator { get; set; }

    #endregion

    #region Constructors

    public OperationCondition(int conditionType, string value)
    {
        ConditionType = conditionType;
        Value = Value;
    }

    public OperationCondition()
    {

    }

    #endregion
}

public class ActionOperationMessage
{
    #region Properties

    [JsonProperty("default_msg")] public int? DefaultMessage { get; set; }

    [JsonProperty("mediatypeid")] public string? MediaTypeId { get; set; }

    [JsonProperty("message")] public string? Message { get; set; }

    [JsonProperty("subject")] public string? Subject { get; set; }

    #endregion
}

public class OperationMessageGroup
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("usrgrpid")] public string? UserGroupId { get; set; }

    #endregion
}

public class OperationMessageUser
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("userid")] public string? UserId { get; set; }

    #endregion
}

public class OperationTemplate
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("templateid")] public string? TemplateId { get; set; }

    #endregion
}

public class OperationInventory
{
    #region Properties

    [JsonProperty("operationid")] public string? OperationId { get; set; }

    [JsonProperty("inventory_mode")] public string? InventoryMode { get; set; }

    #endregion
}
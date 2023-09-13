using Newtonsoft.Json;

namespace Zabbix.Entities
{

    public class LldRule : BaseEntity
    {
        #region Properties

        [JsonProperty("itemid")]
        public override string? EntityId { get; set; }

        [JsonProperty("delay")]
        public string? Delay { get; set; }

        [JsonProperty("hostid")]
        public string? HostId { get; set; }

        [JsonProperty("stringerfaceid")]
        public string? InterfaceId { get; set; }

        [JsonProperty("key_")]
        public string? Key { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("allow_traps")]
        public int? AllowTraps { get; set; }

        [JsonProperty("authtype")]
        public string? AuthType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("follow_redirects")]
        public string? FollowRedirects { get; set; }

        [JsonProperty("http_proxy")]
        public string? HttpProxy { get; set; }

        [JsonProperty("ipmi_sensor")]
        public string? IpmiSensor { get; set; }

        [JsonProperty("jmx_endpostring")]
        public string? JmxEndpostring { get; set; }

        [JsonProperty("lifetime")]
        public string? Lifetime { get; set; }

        [JsonProperty("master_itemid")]
        public int? MasterItemId { get; set; }

        [JsonProperty("output_format")]
        public int? OutputFormat { get; set; }

        [JsonProperty("params")]
        public string? Params { get; set; }

        [JsonProperty("password")]
        public string? Password { get; set; }

        [JsonProperty("post_type")]
        public int? PostType { get; set; }

        [JsonProperty("posts")]
        public string? Posts { get; set; }

        [JsonProperty("privatekey")]
        public string? PrivateKey { get; set; }

        [JsonProperty("publickey")]
        public string? PublicKey { get; set; }

        [JsonProperty("request_method")]
        public string? RequestMethod { get; set; }

        [JsonProperty("retrieve_mode")]
        public int? RetrieveMode { get; set; }

        [JsonProperty("snmp_oid")]
        public string? SnmpOid { get; set; }

        [JsonProperty("ssl_cert_file")]
        public string? SslCertFile { get; set; }

        [JsonProperty("ssl_key_file")]
        public string? SslKeyFile { get; set; }

        [JsonProperty("ssl_key_password")]
        public string? SslKeyPassword { get; set; }

        [JsonProperty("state")]
        public int? State { get; set; }

        [JsonProperty("status")]
        public int? Status { get; set; }

        [JsonProperty("status_codes")]
        public string? StatusCodes { get; set; }

        [JsonProperty("templateid")]
        public string? TemplateId { get; set; }

        [JsonProperty("timeout")]
        public string? Timeout { get; set; }

        [JsonProperty("trapper_hosts")]
        public string? TrapperHosts { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("uuid")]
        public string? Uuid { get; set; }

        [JsonProperty("verify_host")]
        public int? VerifyHost { get; set; }

        [JsonProperty("verify_peer")]
        public int? VerifyPeer { get; set; }

        #endregion Properties

        #region Components

        [JsonProperty("headers")]
        public object? Headers { get; set; }

        [JsonProperty("parameters")]
        public IList<object>? Parameters { get; set; }

        [JsonProperty("query_fields")]
        public IList<object>? QueryFields { get; set; }

        [JsonProperty("filter")] public IList<LldRuleFilter>? Filters { get; set; }
        [JsonProperty("graphs")] public IList<Graph>? Graphs { get; set; }
        [JsonProperty("hostPrototypes")] public IList<HostPrototype>? HostPrototypes { get; set; }
        [JsonProperty("hosts")] public IList<Host>? Hosts { get; set; }
        [JsonProperty("items")] public IList<Item>? Items { get; set; }
        [JsonProperty("triggers")] public IList<Trigger>? Triggers { get; set; }
        [JsonProperty("lld_macro_paths")] public IList<LLdMacroPath>? LLdMacroPaths { get; set; }
        [JsonProperty("preprocessing")] public IList<LLdRulePreprocessing>? LLdRulePreprocessings { get; set; }
        [JsonProperty("lld_rule_overrides")] public IList<LldRuleOverride>? LLdRuleOverrides { get; set; }


        #endregion Components

        #region Constructors

        public LldRule(string delay, string hostid, string interfaceid, string key, string name, int type, string url,
            int valueType)
        {
            Delay = delay;
            HostId = hostid;
            InterfaceId = interfaceid;
            Key = key;
            Name = name;
            Type = type;
            Url = url;
        }
        public LldRule(){}
        #endregion
    }

    public class LldRuleFilterCondition
    {
        #region Properties

        [JsonProperty("macro")]
        public string? Macro { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        [JsonProperty("formulaid")]
        public string? FormulaId { get; set; }

        [JsonProperty("operator")]
        public int? Operator { get; set; }

        #endregion

        #region Constructors

        public LldRuleFilterCondition(string macro, string value)
        {
            Macro = macro;
            Value = value;
        }
        public LldRuleFilterCondition(){}

        #endregion

    }
    public class LldRuleFilter
    {
        #region Properties

        [JsonProperty("evaltype")]
        public int? EvalType { get; set; }

        [JsonProperty("eval_formula")]
        public string? EvalFormula { get; set; }

        [JsonProperty("formula")]
        public string? Formula { get; set; }

        #endregion

        #region Components
        [JsonProperty("conditions")]
        public IList<LldRuleFilterCondition>? Conditions { get; set; }

        #endregion

        #region Constructors

        public LldRuleFilter(IList<LldRuleFilterCondition> conditions, int evalType)
        {
            Conditions = conditions;
            EvalType = evalType;
        }
        public LldRuleFilter(){}

        #endregion

    }
    public class LLdMacroPath
    {
        #region Properties

        [JsonProperty("lld_macro")]
        public string? LLdMacro { get; set; }

        [JsonProperty("path")]
        public string? Path { get; set; }

        #endregion

        #region Constructors

        public LLdMacroPath(string lLdMacro, string path)
        {
            LLdMacro = lLdMacro;
            Path = path;
        }

        public LLdMacroPath()
        {

        }

        #endregion

    }
    public class LLdRulePreprocessing
    {
        #region Properties

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("params")]
        public string? Params { get; set; }

        [JsonProperty("error_handler")]
        public int? ErrorHandler { get; set; }

        [JsonProperty("error_handler_params")]
        public string? ErrorHandlerParams { get; set; }

        #endregion

        #region Constructors

        public LLdRulePreprocessing(int type, string @params, int errorHandler, string errorHandlerParams)
        {
            Type = type;
            Params = @params;
            ErrorHandler = errorHandler;
            ErrorHandlerParams = errorHandlerParams;
        }
        public LLdRulePreprocessing() { }
        #endregion

    }
    public class LldRuleOverride
    {
        #region Properties

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("step")]
        public int? Step { get; set; }

        [JsonProperty("stop")]
        public int? Stop { get; set; }

        #endregion

        #region Components

        [JsonProperty("filter")]
        public LldRuleOverrideFilter? Filter { get; set; }

        [JsonProperty("operations")]
        public IList<LldRuleOverrideOperation>? Operations { get; set; }

        #endregion

        #region Constructos

        public LldRuleOverride(string name, int step)
        {
            Name = name;
            Step = step;
        }
        public LldRuleOverride(){}
        

        #endregion
    }
    public class LldRuleOverrideFilter
    {
        #region Properties
        [JsonProperty("evaltype")]
        public int? EvalType { get; set; }

        [JsonProperty("eval_formula")]
        public string? EvalFormula { get; set; }

        [JsonProperty("formula")]
        public string? Formula { get; set; }
        #endregion

        #region Components

        [JsonProperty("conditions")]
        public IList<LldRuleOverrideFilterCondition>? Conditions { get; set; }

        #endregion

        #region Constructors

        public LldRuleOverrideFilter(int evalType, IList<LldRuleOverrideFilterCondition> conditions)
        {
            Conditions = conditions;
            EvalType = evalType;
        }

        #endregion

    }

    public class LldRuleOverrideFilterCondition
    {
        #region Properties

        [JsonProperty("macro")]
        public string? Macro { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        [JsonProperty("formulaid")]
        public string? FormulaId { get; set; }

        [JsonProperty("operator")]
        public int? Operator { get; set; }

        #endregion

        #region Constructors

        public LldRuleOverrideFilterCondition(string macro, string value)
        {
            Macro = macro;
            Value = value;
        }

        public LldRuleOverrideFilterCondition(){}


        #endregion

    }
    public class LldRuleOverrideOperation
    {
        #region Properties

        [JsonProperty("operationobject")]
        public int? OperationObject { get; set; }

        [JsonProperty("operator")]
        public int? Operator { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        #endregion

        #region Components

        [JsonProperty("opstatus")]
        public LLDRuleOverrideOperationStatus? OpStatus { get; set; }

        [JsonProperty("opdiscover")]
        public LLDRuleOverrideOperationDiscover? OpDiscover { get; set; }

        [JsonProperty("opperiod")]
        public LLDRuleOverrideOperationPeriod? OpPeriod { get; set; }

        [JsonProperty("ophistory")]
        public LLDRuleOverrideOperationHistory? OpHistory { get; set; }

        [JsonProperty("optrends")]
        public LLDRuleOverrideOperationTrends? OpTrends { get; set; }

        [JsonProperty("opseverity")]
        public LLDRuleOverrideOperationSeverity? OpSeverity { get; set; }

        [JsonProperty("optag")]
        public IList<LLDRuleOverrideOperationTag>? OpTag { get; set; }

        [JsonProperty("optemplate")]
        public IList<LLDRuleOverrideOperationTemplate>? OpTemplate { get; set; }

        [JsonProperty("opinventory")]
        public LLDRuleOverrideOperationInventory? OpInventory { get; set; }

        #endregion

        #region Constructors

        public LldRuleOverrideOperation(int operationObject)
        {
            OperationObject = operationObject;
        }

        public LldRuleOverrideOperation() { }

        #endregion

    }

    #region ComponentClasses

    public class LLDRuleOverrideOperationStatus
    {
        [JsonProperty("status")]
        public int? Status { get; set; }

        public LLDRuleOverrideOperationStatus(int status)
        {
            Status = status;
        }
        public LLDRuleOverrideOperationStatus() { }
    }

    public class LLDRuleOverrideOperationDiscover
    {
        [JsonProperty("discover")]
        public int? Discover { get; set; }

        public LLDRuleOverrideOperationDiscover(int discover)
        {
            Discover = discover;
        }
        public LLDRuleOverrideOperationDiscover() { }
    }

    public class LLDRuleOverrideOperationPeriod
    {
        [JsonProperty("delay")]
        public string? Delay { get; set; }

        public LLDRuleOverrideOperationPeriod(string delay)
        {
            Delay = delay;
        }
        public LLDRuleOverrideOperationPeriod() { }
    }

    public class LLDRuleOverrideOperationHistory
    {
        [JsonProperty("history")]
        public string? History { get; set; }

        public LLDRuleOverrideOperationHistory(string history)
        {
            History = history;
        }

        public LLDRuleOverrideOperationHistory() { }
    }

    public class LLDRuleOverrideOperationTrends
    {
        [JsonProperty("trends")]
        public string? Trends { get; set; }

        public LLDRuleOverrideOperationTrends(string trends)
        {
            Trends = trends;
        }
        public LLDRuleOverrideOperationTrends() { }
    }
    public class LLDRuleOverrideOperationSeverity
    {
        [JsonProperty("severity")]
        public int? Severity { get; set; }

        public LLDRuleOverrideOperationSeverity(int severity)
        {
            Severity = severity;
        }
        public LLDRuleOverrideOperationSeverity() { }
    }

    public class LLDRuleOverrideOperationTag
    {
        [JsonProperty("tag")]
        public string? Tag { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        public LLDRuleOverrideOperationTag(string? tag)
        {
            Tag = tag;
        }
        public LLDRuleOverrideOperationTag() { }
    }

    public class LLDRuleOverrideOperationTemplate
    {
        [JsonProperty("templateid")]
        public string? TemplateId { get; set; }
    }

    public class LLDRuleOverrideOperationInventory
    {
        [JsonProperty("inventory_mode")]
        public int? InventoryMode { get; set; }

        public LLDRuleOverrideOperationInventory(int inventoryMode)
        {
            InventoryMode = inventoryMode;
        }
        public LLDRuleOverrideOperationInventory() { }
    }

    #endregion

}

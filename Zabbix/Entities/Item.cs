using Newtonsoft.Json;

namespace Zabbix.Entities;

public enum ItemProperties
{
    itemid,
    type,
    snmp_oid,
    hostid,
    name,
    key_,
    delay,
    history,
    trends,
    status,
    value_type,
    trapper_hosts,
    units,
    logtimefmt,
    templateid,
    valuemapid,
    @params,
    ipmi_sensor,
    authtype,
    username,
    password,
    publickey,
    privatekey,
    flags,
    interfaceid,
    description,
    inventory_link,
    evaltype,
    jmx_endpoint,
    master_itemid,
    timeout,
    url,
    query_fields,
    posts,
    status_codes,
    follow_redirects,
    post_type,
    http_proxy,
    headers,
    retrieve_mode,
    request_method,
    output_format,
    ssl_cert_file,
    ssl_key_file,
    ssl_key_password,
    verify_peer,
    verify_host,
    allow_traps,
    uuid,
    state,
    error,
    parameters,
    lastclock,
    lastns,
    lastvalue,
    prevvalue
}

public class Item : BaseEntity
{
    #region Properties

    [JsonProperty("itemid")] public override string? EntityId { get; set; }

    [JsonProperty("type")] public int? Type { get; set; }

    [JsonProperty("snmp_oid")] public string? SnmpOid { get; set; }

    [JsonProperty("hostid")] public string? Hostid { get; set; }

    [JsonProperty("name")] public string? Name { get; set; }

    [JsonProperty("key_")] public string? Key { get; set; }

    [JsonProperty("delay")] public string? Delay { get; set; }

    [JsonProperty("history")] public string? History { get; set; }

    [JsonProperty("trends")] public string? Trends { get; set; }

    [JsonProperty("status")] public int? Status { get; set; }

    [JsonProperty("value_type")] public int? ValueType { get; set; }

    [JsonProperty("trapper_hosts")] public string? TrapperHosts { get; set; }

    [JsonProperty("units")] public string? Units { get; set; }

    [JsonProperty("logtimefmt")] public string? Logtimefmt { get; set; }

    [JsonProperty("templateid")] public string? Templateid { get; set; }

    [JsonProperty("valuemapid")] public string? Valuemapid { get; set; }

    [JsonProperty("params")] public string? Params { get; set; }

    [JsonProperty("ipmi_sensor")] public string? IpmiSensor { get; set; }

    [JsonProperty("authtype")] public string? Authtype { get; set; }

    [JsonProperty("username")] public string? Username { get; set; }

    [JsonProperty("password")] public string? Password { get; set; }

    [JsonProperty("publickey")] public string? Publickey { get; set; }

    [JsonProperty("privatekey")] public string? Privatekey { get; set; }

    [JsonProperty("flags")] public string? Flags { get; set; }

    [JsonProperty("interfaceid")] public string? Interfaceid { get; set; }

    [JsonProperty("description")] public string? Description { get; set; }

    [JsonProperty("inventory_link")] public int? InventoryLink { get; set; }

    [JsonProperty("evaltype")] public string? Evaltype { get; set; }

    [JsonProperty("jmx_endpoint")] public string? JmxEndpoint { get; set; }

    [JsonProperty("master_itemid")] public int? MasterItemid { get; set; }

    [JsonProperty("timeout")] public string? Timeout { get; set; }

    [JsonProperty("url")] public string? Url { get; set; }

    [JsonProperty("query_fields")] public IList<object>? QueryFields { get; set; }

    [JsonProperty("posts")] public string? Posts { get; set; }

    [JsonProperty("status_codes")] public string? StatusCodes { get; set; }

    [JsonProperty("follow_redirects")] public int? FollowRedirects { get; set; }

    [JsonProperty("post_type")] public int? PostType { get; set; }

    [JsonProperty("http_proxy")] public string? HttpProxy { get; set; }

    [JsonProperty("headers")] public IList<object>? Headers { get; set; }

    [JsonProperty("retrieve_mode")] public int? RetrieveMode { get; set; }

    [JsonProperty("request_method")] public int? RequestMethod { get; set; }

    [JsonProperty("output_format")] public int? OutputFormat { get; set; }

    [JsonProperty("ssl_cert_file")] public string? SslCertFile { get; set; }

    [JsonProperty("ssl_key_file")] public string? SslKeyFile { get; set; }

    [JsonProperty("ssl_key_password")] public string? SslKeyPassword { get; set; }

    [JsonProperty("verify_peer")] public int? VerifyPeer { get; set; }

    [JsonProperty("verify_host")] public int? VerifyHost { get; set; }

    [JsonProperty("allow_traps")] public int? AllowTraps { get; set; }

    [JsonProperty("uuid")] public string? Uuid { get; set; }

    [JsonProperty("state")] public int? State { get; set; }

    [JsonProperty("error")] public string? Error { get; set; }

    [JsonProperty("parameters")] public IList<object>? Parameters { get; set; }

    [JsonProperty("lastclock")] public string? Lastclock { get; set; }

    [JsonProperty("lastns")] public int? Lastns { get; set; }

    [JsonProperty("lastvalue")] public string? Lastvalue { get; set; }

    [JsonProperty("prevvalue")] public string? Prevvalue { get; set; }

    #endregion

    #region Components

    [JsonProperty("hosts")] public IList<Host>? Hosts;

    [JsonProperty("interfaces")] public IList<HostInterface>? Interfaces;

    [JsonProperty("triggers")] public IList<Trigger>? Triggers;

    [JsonProperty("graphs")] public IList<Graph>? Graphs;

    [JsonProperty("discoveryRule")] public IList<DiscoveryRule>? DiscoverRules;

    [JsonProperty("itemDiscovery")] public IList<ItemDiscovery>? ItemDiscoveries;

    [JsonProperty("preprocessing")] public IList<ItemPreprocessing>? Preprocessings;

    [JsonProperty("tags")] public IList<Tag>? Tags;

    [JsonProperty("valuemap")] public IList<ValueMap>? ValueMaps;

    #endregion

    #region Constructors

    public Item(string delay, string hostid, string interfaceid, string key, string name, int type, string url,
        int valueType)
    {
        Delay = delay;
        Hostid = hostid;
        Interfaceid = interfaceid;
        Key = key;
        Name = name;
        Type = type;
        Url = url;
        ValueType = valueType;
    }
    public Item(){}
    #endregion
}

public class ItemPreprocessing
{
    #region Properties

    [JsonProperty("type")] public int? Type { get; set; }

    [JsonProperty("params")] public string? Params { get; set; }

    [JsonProperty("error_handler")] public int? ErrorHandler { get; set; }

    [JsonProperty("error_handler_params")] public string? ErrorHandlerParams { get; set; }

    #endregion

    #region Constructors

    public ItemPreprocessing(int type, string @params, int errorHandler, string errorHandlerParams)
    {
        Type = type;
        Params = @params;
        ErrorHandler = errorHandler;
        ErrorHandlerParams = errorHandlerParams;
    }
    public ItemPreprocessing(){}

    #endregion
}

public class ItemDiscovery
{
    #region Properties

    [JsonProperty("itemdiscoveryid")] public string? ItemDiscoveryId { get; set; }

    [JsonProperty("itemid")] public string? ItemId { get; set; }

    [JsonProperty("parent_itemid")] public string? ParentItemId { get; set; }

    [JsonProperty("key_")] public string? Key { get; set; }

    [JsonProperty("lastcheck")] public string? LastCheck { get; set; }

    [JsonProperty("ts_delete")] public string? TsDelete { get; set; }

    #endregion
}
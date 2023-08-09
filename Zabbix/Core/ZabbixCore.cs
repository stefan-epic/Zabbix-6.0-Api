using Newtonsoft.Json;
using System.Text;
using Zabbix.Entities;
using Zabbix.Services;

namespace Zabbix.Core;

//TODO: massAdd massdelete massupdate
public class ZabbixCore : ICore
{
    private volatile string? _authenticationToken = "";
    private readonly HttpClient _httpClient;
    private User? _loggedInUser;
    private readonly JsonSerializerSettings _serializerSettings;
    private readonly string _url;

    public ZabbixCore(string url, string username, string password)
    {

        if (password == null)
        {
            throw new ArgumentNullException(nameof(password));
        }
        if (url == null)
        {
            throw new ArgumentNullException(nameof(url));
        }
        if (username == null)
        {
            throw new ArgumentNullException(nameof(username));
        }

        _serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
        };


        _url = url;
        _httpClient = new HttpClient();
        Hosts = new HostService(this);
        HostGroups = new HostGroupService(this);
        WebScenarios = new WebScenarioService(this);
        Users = new UserService(this);
        Triggers = new TriggerService(this);
        Problems = new ProblemService(this);
        Reports = new ReportService(this);
        Interfaces = new HostInterfaceService(this);
        Alerts = new AlertService(this);
        Events = new EventService(this);
        Actions = new ActionService(this);
        Authentication = new AuthenticationService(this);
        UserMacros = new UserMacroService(this);
        Roles = new RoleService(this);
        Items = new ItemService(this);
        AuditLogs = new AuditLogService(this);
        Proxys = new ProxyService(this);
        ValueMaps = new ValueMapService(this);
        DiscoveredHosts = new DiscoveredHostService(this);
        DiscoveryChecks = new DiscoveryCheckService(this);
        DiscoveredServices = new DiscoveredServiceService(this);
        DiscoveryRules = new DiscoveryRuleService(this);
        TriggerPrototypess = new TriggerPrototypeService(this);
        Trends = new TrendService(this);
        LLDRules = new LLDRuleService(this);
        UserGroups = new UserGroupService(this);
        Authenticate(username, password);
    }

    public T SendRequest<T>(object? @params, string method)
    {
        lock (_httpClient)
        {
            var token = CheckAndGetToken();
            return SendRequest<T>(@params, method, token);
        }
    }

    public T SendRequest<T>(object? @params, string method, string? token)
    {
        lock (_httpClient)
        {
            var request = GetRequest(@params, method, token);

            var requestData = new StringContent(JsonConvert.SerializeObject(request, _serializerSettings), Encoding.UTF8, "application/json");
            var response = _httpClient.PostAsync(_url, requestData).Result;
            response.EnsureSuccessStatusCode();

            var responseData = response.Content.ReadAsStringAsync().Result;
            var ret = HandleResponse<T>(request.Id, responseData);

            return ret;
        }
    }

    public async Task<T> SendRequestAsync<T>(object? @params, string method)
    {
        var token = CheckAndGetToken();
        return await SendRequestAsync<T>(@params, method, token);
    }

    public async Task<T> SendRequestAsync<T>(object? @params, string method, string? token)
    {
        var request = GetRequest(@params, method, token);
        _httpClient.DefaultRequestHeaders.Add("content-type", "application/json-rpc");

        var requestData = new StringContent(JsonConvert.SerializeObject(request, _serializerSettings), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(_url, requestData).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        return HandleResponse<T>(request.Id, responseData);
    }


    public void Dispose()
    {
        Users.Logout();
        _httpClient.Dispose();
    }




    private void Authenticate(string user, string password)
    {
        _loggedInUser = Users.Login(user, password);
        _authenticationToken = _loggedInUser.SessionId;
    }

    private async void AuthenticateAsync(string user, string password)
    {
        _loggedInUser = await Users.LoginAsync(user, password);
        _authenticationToken = _loggedInUser.SessionId;
    }


    private T HandleResponse<T>(string requestId, string responseData)
    {
        var response = JsonConvert.DeserializeObject<Response<T>>(responseData, _serializerSettings);

        if (response == null)
        {
            throw new NullReferenceException($"Object Deserialization is null for {responseData} with Id {requestId}");
        }

        if (response.Error != null)
        {
            throw new Exception(response.Error.Message, new Exception($"{response.Error.Data} - code:{response.Error.Code}"));
        }

        if (response.Result == null)
        {
            throw new NullReferenceException($"Result is null for {responseData} with Id {requestId}. Possibly an error with Deserialization");
        }

        if (response.Id != requestId)
        {
            throw new Exception($"The response id ({response.Id}) does not match the request id ({requestId})");
        }

        return response.Result;
    }

    private Request GetRequest(object? @params, string method, string? authenticationToken)
    {
        return new Request
        {
            Method = method,
            Params = @params,
            Id = Guid.NewGuid().ToString(),
            Auth = authenticationToken
        };
    }

    private string? CheckAndGetToken()
    {
        var token = _authenticationToken;
        if (token == "") throw new InvalidOperationException("This zabbix core isn't authenticated.");

        return token;
    }

    #region Services

    public HostService Hosts;
    public HostGroupService HostGroups;
    public WebScenarioService WebScenarios;
    public UserService Users;
    public TriggerService Triggers;
    public ProblemService Problems;
    public ReportService Reports;
    public HostInterfaceService Interfaces;
    public AlertService Alerts;
    public EventService Events;
    public ActionService Actions;
    public AuthenticationService Authentication;
    public UserMacroService UserMacros;
    public RoleService Roles;
    public ItemService Items;
    public AuditLogService AuditLogs;
    public ProxyService Proxys;
    public ValueMapService ValueMaps;
    public DiscoveredHostService DiscoveredHosts;
    public DiscoveredServiceService DiscoveredServices;
    public DiscoveryRuleService DiscoveryRules;
    public DiscoveryCheckService DiscoveryChecks;
    public TriggerPrototypeService TriggerPrototypess;
    public TrendService Trends;
    public LLDRuleService LLDRules;
    public UserGroupService UserGroups;



    #endregion
}
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using Zabbix.Entities;
using Zabbix.Services;
using ZabbixApi.Helper;

namespace Zabbix.Core
{

    //TODO: massAdd massdelete massupdate
    public class ZabbixCore : ICore
    {
        private string _url;

        private volatile string _authenticationToken;
        private HttpClient _httpClient;
        private JsonSerializerSettings _serializerSettings;
        private User _loggedInUser;

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
        #endregion

        public ZabbixCore(string url, string username, string password)
        {
            Check.IsNotNullOrWhiteSpace(url, "ZabbixApi.url");
            Check.IsNotNullOrWhiteSpace(username, "ZappixApi.username");
            Check.IsNotNullOrWhiteSpace(password, "ZabbixApi.password");

            Init(url);
            Authenticate(username, password);

        }

        private void Init(string url)
        {
            _serializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                Converters = new JsonConverter[] { new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter() }
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
        }

        private void Authenticate(string user, string password)
        {
            _loggedInUser = Users.Login(user, password);
            _authenticationToken = _loggedInUser.SessionId;
        }

        private Task AuthenticateAsync(string user, string password)
        {
            throw new NotImplementedException();
        }

        public T SendRequest<T>(object @params, string method)
        {
            lock (_httpClient)
            {
                var token = CheckAndGetToken();
                return SendRequest<T>(@params, method, token);
            }
        }
        public T SendRequest<T>(object @params, string method, string token)
        {
            lock (_httpClient)
            {
                var request = GetRequest(@params, method, token);

                var requestData = new StringContent(JsonConvert.SerializeObject(request, _serializerSettings), Encoding.UTF8, "application/json");
                var response = _httpClient.PostAsync(_url, requestData).Result;
                response.EnsureSuccessStatusCode();

                var responseData = response.Content.ReadAsStringAsync().Result;
                return HandleResponse<T>(request.Id, responseData);
            }
        }
        public Task<T> SendRequestAsync<T>(object @params, string method)
        {
            throw new NotImplementedException();
        }

        public async Task<T> SendRequestAsync<T>(object @params, string method, string token)
        {

            var request = GetRequest(@params, method, token);
            _httpClient.DefaultRequestHeaders.Add("content-type", "application/json-rpc");

            var requestData = new StringContent(JsonConvert.SerializeObject(request, _serializerSettings), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(_url, requestData).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return HandleResponse<T>(request.Id, responseData);
        }


        private T HandleResponse<T>(string requestId, string responseData)
        {
            
            var response = JsonConvert.DeserializeObject<Response<T>>(responseData, _serializerSettings);

            if (response.Error != null)
            {
                throw new Exception(response.Error.Message, new Exception(string.Format("{0} - code:{1}", response.Error.Data, response.Error.Code)));
            }

            if (response.Id != requestId)
                throw new Exception(string.Format("The response id ({0}) does not match the request id ({1})", response.Id, requestId));

            return response.Result;
        }


        public void Dispose()
        {
            Users.Logout();
            throw new NotImplementedException();
        }

        private Request GetRequest(object @params, string method, string authenticationToken)
        {
            return new Request
            {
                Method = method,
                Params = @params,
                Id = Guid.NewGuid().ToString(),
                Auth = authenticationToken
            };
        }
        private string CheckAndGetToken()
        {
            var token = _authenticationToken;
            if (token == null)
            {
                throw new InvalidOperationException("This zabbix core isn't authenticated.");
            }

            return token;
        }




    }
}
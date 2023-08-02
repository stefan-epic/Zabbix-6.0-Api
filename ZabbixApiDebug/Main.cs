using Zabbix.Core;
using Zabbix.Entities;
using Zabbix.Filter;
using Zabbix.Helpers;
using Zabbix.Services;

namespace ZabbixApiDebug
{
    internal class Main
    {

        //outputfilter = object properties to be returned
        //filter = Return only those results that exactly match the given filter.        Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.

        /*
        "selectParentTemplates": [
           "templateid",
           "name"
        ]
         */
        public void Run()
        {


            string url = "http://10.10.51.194/api_jsonrpc.php";
            string username = "Admin";
            string password = "zabbix";

            ZabbixCore core = new ZabbixCore(url, username, password);
            List<Host> hosts =  core.Hosts.Get().ToList();

            RequestFilter<HostProperties, HostInclude> filter = new();
            filter.OutputFilter.AddFilter(HostProperties.hostid);
            filter.IncludeFilter.Set(HostInclude.selectGroups, "extend");
            /*


            ReflectionHelper<Host> r = new();
            List<string> l = r.GetJsonPropertiesOfEntity();

            foreach (string s in l)
            {
                Console.WriteLine(s+",");
            }
            */


            RequestFilter<HostProperties, HostInclude> rqFilter = new();

            rqFilter.OutputFilter.AddFilter(HostProperties.host);

            rqFilter.ObjectFilter.Set(HostProperties.host, "Zabbix server");
            rqFilter.ObjectFilter.Append(HostProperties.host, "Linux server");

            rqFilter.IncludeFilter.Set(HostInclude.selectGroups, "name");

            core.Hosts.Get(rqFilter);
            /*

            Dictionary<HostInclude, object> kvp = new Dictionary<HostInclude, object>
            {
                { HostInclude.with_monitored_items, "true" },
                { HostInclude.selectGroups, new object[] { "name" } }
            };

            OutputFilter<HostProperties> fo = new();
            fo.AddFilter(HostProperties.hostid);
            fo.AddFilter(HostProperties.host);

            ObjectFilter obj = new ObjectFilter();
            obj.Set("host", "Zabbix server");
            obj.Append("host", "Linux server");
            

            List<Host> hosts = core.Hosts.Get(null, fo, kvp, null).ToList();
            List<HostGroup> groups = hosts[0].Groups.ToList();

            foreach (Host host in hosts)
            {
                Console.WriteLine(host.Name);
            }

            foreach (HostGroup group in groups)
            {
                Console.WriteLine(group.Name);
            }
            */






            //Dictionary<HostInclude, object> include = new();
            //include.Add(HostInclude.selectGroups, "extend");
            //core.Hosts.Get(null, new { output = "hostid" }, new Dictionary<HostInclude, object> { 
            //Console.WriteLine(h2.Groups.First().Name);

            /*
            HostGroup group = core.HostGroups.Get().ToList()[2];
            Host h = new Host();
            h.HostName = "localhost";
            h.Groups = new List<HostGroup>
            {
                group
            };

            string ret = core.Hosts.Create(h);
            Console.WriteLine(ret);
            Console.WriteLine(h.ToString());
            */


            /*
            
            string id = core.Hosts.Get().First().Hostid;
            List<WebScenarioStep> steps = new List<WebScenarioStep>();
            WebScenarioStep step = new WebScenarioStep("TestStep", "1", "http://10.10.51.194:8080/");
            step.Required = "{\"id\":3}";
            step.StatusCodes = "200";
            steps.Add(step);

            WebScenario scenario = new WebScenario("Test", id, steps);
            core.WebScenarios.Create(scenario);
            */
            /*
            User u = core.Users.Login("Admin", "zabbix");
            core.Users.Get().ToList().ForEach(n => Console.WriteLine(n.Username));
            */

            /*
            List<Problem> problems = core.Problems.Get().ToList();
            problems.ForEach(p => Console.WriteLine(p.Name));
            */

            //core.Events.Get().ToList().ForEach(n => Console.WriteLine(n.Name));

        }
    }
}


/*
  {
    "jsonrpc": "2.0",
    "method": "host.get",
    "params": {
        "output": ["hostid"],
        "selectGroups": "extend",
        "filter": {
            "host": [
                "Zabbix server"
            ]
        }
    },
    "auth": "038e1d7b1735c6a5436ee9eae095879e",
    "id": 2
}
 */
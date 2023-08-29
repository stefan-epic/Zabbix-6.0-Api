# Zabbix 6.0 API Library for C#

This is a C# library designed to simplify interactions with the Zabbix API (version 6.0). It provides an intuitive way to perform operations such as creating, updating, deleting and getting entties for Zabbix.

## Still in Development
Please note that this library is still under active development, there may be bugs. Your assistance in identifying and addressing these issues is greatly appreciated.

## Installation

Currently, the library can be used by cloning this repository. I plan to release a NuGet package once I am satisfied with the stability and features.

## Usage

First, let's establish a connection to the Zabbix server using your credentials:
```csharp
string url = "http://ZABBIX_SERVER/api_jsonrpc.php";
string username = "Admin";
string password = "zabbix";

ZabbixCore core = new ZabbixCore(url, username, password);
```

### Creating Entities
Creating an Entity returns its remote Zabbix id, Zabbix will set every unset value to its default value. <br/>
It's important to note that each entity has a set of required properties that must be configured, as indicated by the constructor. (Do note that this constructor isn't available for every entity yet; refer to the Zabbix API documentation when unsure.)
```csharp
Host serverHost = new Host("Server", new List<HostGroup>() { linuxServers });
string createdServerHostId = core.Hosts.Create(serverHost);
```
### Updating Entities
Updating an entity also returns its Zabbix ID. During the update process, only the properties that are explicitly set (not null) will be sent to Zabbix.
```csharp
serverHost.Status = 1;
string updatedServerHostId = core.Hosts.Update(serverHost);
```
### Deleting Entities
Deleting a Entity returns its former remote Zabbix id. <br/>
When deleting a Entity you need to know the remote Zabbix id.
```csharp
string updatedServerHostId = core.Hosts.Delete(serverHost);
string updatedServerHostId = core.Hosts.Delete(createdServerHostId);
```
### Getting Entities
Getting Entities is a bit more complicated, but once you understand how it works its very simple.<br/>

This is a simple Get, it will return every Host that is configured on Zabbix.<br/>
```csharp
List<Host> hosts = core.Hosts.Get().ToList();
```
However, the Get method can also accept a RequestFilter as its parameter.
### RequestFilter (Will likely change quite a bit during Development)
The RequestFilter can be employed to query Zabbix based on specific criteria or to fine-tune the output.<br/> 
It consists of three main filters.

#### OutputFilter
The OutputFilter is very simple, you can tell Zabbix which Properties you want to get back from the requested Entities.<br/>
The below code will ask Zabbix to return every Host but only with their hostname and status Properties(awell as their ids).
```csharp
  RequestFilter<HostProperties, HostInclude> requestFilter = new();
  requestFilter.OutputFilter.AddFilter(HostProperties.host);
  requestFilter.OutputFilter.AddFilter(HostProperties.status);

  List<Host> hosts = core.Hosts.Get(requestFilter).ToList();
```
#### IncludeFilter
The IncludeFilter is utilized to expand the output of a request. <br/>
The following example retrieves all hosts from Zabbix along with their associated groups.
```csharp
RequestFilter<HostProperties, HostInclude> requestFilter = new();
requestFilter.IncludeFilter.Set(HostInclude.selectGroups);

List<Host> hosts = core.Hosts.Get(requestFilter).ToList();
```
You can also provide the IncludeFilter with a list of properties you want to obtain from the requested include query, similar to the OutputFilter.
```csharp
RequestFilter<HostProperties, HostInclude> requestFilter = new();
requestFilter.IncludeFilter.Set(HostInclude.selectGroups, new List<string>(){"groupname", "groupid"});

List<Host> hosts = core.Hosts.Get(requestFilter).ToList();
```
#### ObjectFilter
The ObjectFilter can be used to query for a specific Entity or every Entity that meets a certian Criteria.<br/>
The below code returns every Host that either has the name "Zabbix Server" or "Linux Server"
```csharp
    RequestFilter<HostProperties, HostInclude> rqFilter = new();
    rqFilter.ObjectFilter.Set(HostProperties.host, "Zabbix Server");
    rqFilter.ObjectFilter.Append(HostProperties.host, "Linux Server");
    var list = core.Hosts.Get(rqFilter);
```
### CRUD operations
Most entities support the CRUD operations and some include some extra Operations. <br/>
Every Crud operation can be called with either a single Entity or a List of Entities. <br/>


## Contribution
I welcome contributions and improvements to this library. Please feel free to open issues and submit pull requests.

## Credit
Lots of Code has been reused from https://github.com/HenriqueCaires/ZabbixApi/tree/master

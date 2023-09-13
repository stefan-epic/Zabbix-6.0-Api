# Zabbix 6.0 API Library for C#

This is a C# library designed to simplify interactions with the Zabbix API (version 6.0). It provides an intuitive way to perform operations such as creating, updating, deleting and getting entties for Zabbix.

## Still in Development
Please note that this library is still under active development, there are probably a lot of bugs. Your assistance in identifying and addressing these issues is greatly appreciated.

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
It's important to note that each entity has a set of required properties that must be configured, as indicated by the constructor.
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
This is a simple Get, it will return every Host that is configured on Zabbix.<br/>
```csharp
List<Host> hosts = core.Hosts.Get().ToList();
```
However, the Get method can also accept a FilterOptions object as its parameter. Every entity has its own FilterOptions object named *Entityname*FilterOptions.<br/>
The FilterOptions can be initialized directly via the constructor like so:

```csharp
var hostsWithItems = core.Hosts.Get(new() { SelectItems = "extend"});
```
if you want to for example query the Hosts items to only return certain properties you can pass it a list of strings like so:
```csharp
var hostsWithItems = core.Hosts.Get(new() { SelectItems = new List<string>(){"hostid", "itemid"}});
```
#### Attention
The count related FilterOptions currently do not work<br/>
If you want to set any of the filter properties to "extend" (at least those which support it) do not use a list:
```csharp
//THIS IS WRONG
var hostsWithItems = core.Hosts.Get(new() { SelectItems = new List<string>(){"extend"}});

//Do this instead
var hostsWithItems = core.Hosts.Get(new() { SelectItems = "extend");
```
Use a list if you're Querying for any property. For example:
```csharp
//This is correct
var hostsWithItems = core.Hosts.Get(new() { SelectItems = new List<string>(){"hostid"}});
```
The exact meaning and usage of each FilterOption can be found on the Zabbix Docs under the Get section of the entity:
https://www.zabbix.com/documentation/6.0/en/manual/api/reference

### CRUD operations
Most entities support the CRUD operations and some include some extra Operations. <br/>
Every Crud operation can be called with either a single Entity or a List of Entities. <br/>


## Contribution
I welcome contributions and improvements to this library. Please feel free to open issues and submit pull requests.

## Credit
Lots of Code has been reused from https://github.com/HenriqueCaires/ZabbixApi/tree/master

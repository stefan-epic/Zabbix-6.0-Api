# Zabbix 6.0 API Library for C#

This is a C# library designed to simplify interactions with the Zabbix API (version 6.0). It provides an intuitive way to perform operations (synchronously and asynchronously) such as creating, updating, deleting and getting entties for Zabbix.

## Still in Development
Please note that this library is still under active development, there are probably a lot of bugs. Your assistance in identifying and addressing these issues is greatly appreciated.

## Installation

Currently, the library can be used by either cloning this repository or by installing the NuGet package https://www.nuget.org/packages/Zabbix.Api.NET/
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
//By Entity
string updatedServerHostId = core.Hosts.Delete(serverHost);

//Or also by Id
string updatedServerHostId = core.Hosts.Delete(createdServerHostId);
```
### Getting Entities
This is a simple Get, it will return every Host that is configured on Zabbix.
```csharp
List<Host> hosts = core.Hosts.Get().ToList();
```
This will return the amount of configured Hosts on Zabbix:
```csharp
int hostAmount = core.Hosts.CountOutput();
```

This is will return every Host that is configured on Zabbix as a Dictionary where their Id is the Key.

```csharp
Dictionary<string, Host> hosts = core.Hosts.PreserveKeys();
```
However, the Get, CountOutput and PreserveKeys method can also accept a FilterOptions object as its parameter. Every entity has its own FilterOptions object named *Entityname*FilterOptions.<br/>
The FilterOptions can be initialized directly via the constructor like so:

```csharp
var hosts = core.Hosts.Get(new()
{
	HostIds = new List<string>(){"12312","32323"}
});
```

Every query (every FilterOption Prop that has a 'Select' in its name) can be used in multiple ways:

The Default Constructor will set it to "extend"
```csharp
var hosts = core.Hosts.Get(new()
{
	SelectItems = new()
});
```

Return every Host and its Items but with only their 'Delay', 'Hostid' and 'ItemId' property set
```csharp
var hosts = core.Hosts.Get(new()
{
	SelectItems = new("delay", "hostid")
});
``` 
There are two additional Constructors for ZabbixQuery, one accepts a ``object`` and the other accepts a ``IEnumerable<string>``. <br/>
When using those, keep in mind that if you want to set the value of a query to "extend", it cannot be inside a list. 

For example:
```csharp
var hosts = core.Hosts.Get(new()
{
    //this would not work
    SelectItems = new(new List<string>(){"extend"})

});
```

The exact meaning and usage of each FilterOption can be found on the Zabbix Docs under the Get section of the entity:
https://www.zabbix.com/documentation/6.0/en/manual/api/reference

### Attention
The 'count' option for queries is currently not supported <br/>


### CRUD operations
Most entities support the CRUD operations and some include some extra Operations. <br/>
Every Crud operation can be called with either a single Entity or a List of Entities. <br/>
Every operation has a Async Variant

## Integration Tests
:heavy_exclamation_mark: The Integration Tests are not meant to be run on a Productive System :heavy_exclamation_mark:
<br/>
The reason for that is because they can potentially change the state of Zabbix. For example, during the HostTests, if the creation is successful but the deletion fails, Zabbix will now have a stray host that will need to be deleted manually.

The integration tests are mostly there for development purposes, so I can make changes and ensure that the base functionality of the Library is intact.

A automated set up for the test enviroment is planned.

## Contribution
I welcome contributions and improvements to this library. Please feel free to open issues and submit pull requests.

## Credit
Lots of Code has been reused from https://github.com/HenriqueCaires/ZabbixApi/tree/master

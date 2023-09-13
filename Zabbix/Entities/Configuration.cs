using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{

    public class ImportConfiguration : Configuration
    {
        [JsonProperty("rules")] public ImportRules? Rules { get; set; } = new();
        [JsonProperty("source")] public string? Source { get; set; }

    }

    public class ExportConfiguration : Configuration
    {
        [JsonProperty("prettyprint")] public bool? PrettyPrint { get; set; }
        [JsonProperty("options")] public ExportOptions? Options { get; set; }

    }

    public class Configuration : BaseEntity
    {
        [JsonProperty("format")] public string? Format { get; set; }
    }

    public class ImportRules
    {
        [JsonProperty("discoveryRules")] public CreateUpdateDeleteRule? DiscoveryRules { get; set; } = new();
        [JsonProperty("graphs")] public CreateUpdateDeleteRule? Graphs { get; set; } = new();
        [JsonProperty("groups")] public CreateUpdateRule? Groups { get; set; } = new();
        [JsonProperty("hosts")] public CreateUpdateRule? Hosts { get; set; } = new();
        [JsonProperty("httptests")] public CreateUpdateDeleteRule? HttpTests { get; set; } = new();
        [JsonProperty("images")] public CreateUpdateRule? Images { get; set; } = new();
        [JsonProperty("items")] public CreateUpdateDeleteRule? Items { get; set; } = new();
        [JsonProperty("maps")] public CreateUpdateRule? Maps { get; set; } = new();
        [JsonProperty("mediaTypes")] public CreateUpdateRule? MediaTypes { get; set; } = new();
        [JsonProperty("templateLinkage")] public CreateDeleteRule? TemplateLinkage { get; set; } = new();
        [JsonProperty("templates")] public CreateUpdateRule? Templates { get; set; } = new();
        [JsonProperty("templateDashboards")] public CreateUpdateDeleteRule? TemplateDashboards { get; set; } = new();
        [JsonProperty("triggers")] public CreateUpdateDeleteRule? Triggers { get; set; } = new();
        [JsonProperty("valueMaps")] public CreateUpdateDeleteRule? ValueMaps { get; set; } = new();
    }
    public class CreateUpdateRule
    {
        [JsonProperty("createMissing")] public bool? CreateMissing = true;
        [JsonProperty("updateExisting")] public bool? UpdateExisting = true;

    }
    public class CreateDeleteRule
    {
        [JsonProperty("createMissing")] public bool? CreateMissing = true;
        [JsonProperty("deleteMissing")] public bool? DeleteMissing = true;

    }

    public class CreateUpdateDeleteRule
    {
        [JsonProperty("createMissing")] public bool? CreateMissing = true;
        [JsonProperty("updateExisting")] public bool? UpdateExisting = true;
        [JsonProperty("deleteMissing")] public bool? DeleteMissing = true;
    }

    public class ExportOptions
    {
        [JsonProperty("groups")] public IList<string>? Groups { get; set; }
        [JsonProperty("hosts")] public IList<string>? Hosts { get; set; }
        [JsonProperty("images")] public IList<string>? Images { get; set; }
        [JsonProperty("maps")] public IList<string>? Maps { get; set; }
        [JsonProperty("mediatypes")] public IList<string>? MediaTypes { get; set; }
        [JsonProperty("templates")] public IList<string>? Templates { get; set; }
    }
}

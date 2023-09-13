using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public class Map : BaseEntity
    {
        #region Properties

        [JsonProperty("sysmapid")]
        public string? SysmapId { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("backgroundid")]
        public string? BackgroundId { get; set; }

        [JsonProperty("expand_macros")]
        public int? ExpandMacros { get; set; }

        [JsonProperty("expandproblem")]
        public int? ExpandProblem { get; set; }

        [JsonProperty("grid_align")]
        public int? GridAlign { get; set; }

        [JsonProperty("grid_show")]
        public int? GridShow { get; set; }

        [JsonProperty("grid_size")]
        public int? GridSize { get; set; }

        [JsonProperty("highlight")]
        public int? Highlight { get; set; }

        [JsonProperty("iconmapid")]
        public string? IconMapId { get; set; }

        [JsonProperty("label_format")]
        public int? LabelFormat { get; set; }

        [JsonProperty("label_location")]
        public int? LabelLocation { get; set; }

        [JsonProperty("label_string_host")]
        public string? LabelStringHost { get; set; }

        [JsonProperty("label_string_hostgroup")]
        public string? LabelStringHostGroup { get; set; }

        [JsonProperty("label_string_image")]
        public string? LabelStringImage { get; set; }

        [JsonProperty("label_string_map")]
        public string? LabelStringMap { get; set; }

        [JsonProperty("label_string_trigger")]
        public string? LabelStringTrigger { get; set; }

        [JsonProperty("label_type")]
        public int? LabelType { get; set; }

        [JsonProperty("label_type_host")]
        public int? LabelTypeHost { get; set; }

        [JsonProperty("label_type_hostgroup")]
        public int? LabelTypeHostGroup { get; set; }

        [JsonProperty("label_type_image")]
        public int? LabelTypeImage { get; set; }

        [JsonProperty("label_type_map")]
        public int? LabelTypeMap { get; set; }

        [JsonProperty("label_type_trigger")]
        public int? LabelTypeTrigger { get; set; }

        [JsonProperty("markelements")]
        public int? MarkElements { get; set; }

        [JsonProperty("severity_min")]
        public int? SeverityMin { get; set; }

        [JsonProperty("show_unack")]
        public int? ShowUnack { get; set; }

        [JsonProperty("userid")]
        public string? UserId { get; set; }

        [JsonProperty("private")]
        public int? Private { get; set; }

        [JsonProperty("show_suppressed")]
        public int? ShowSuppressed { get; set; }
        #endregion

        #region Components

        [JsonProperty("iconmap")] public IList<IconMap>? IconMaps { get; set; }
        [JsonProperty("links")] public IList<MapLink>? MapLinks { get; set; }
        [JsonProperty("selements")] public IList<MapElement>? MapElements { get; set; }
        [JsonProperty("urls")] public IList<MapUrl>? MapUrls { get; set; }
        [JsonProperty("users")] public IList<MapUser>? MapUsers { get; set; }
        [JsonProperty("userGroups")] public IList<MapUserGroup>? MapUserGroups { get; set; }
        [JsonProperty("shapes")] public IList<MapShape>? Shapes { get; set; }
        [JsonProperty("lines")] public IList<MapLine>? Lines { get; set; }


        #endregion

        #region Constructors

        public Map(int height, string name, int width)
        {
            Height = height;
            Name = name;
            Width = width;
        }
        public Map() { }

        #endregion
    }

    public class MapElement
    {
        #region Properties

        [JsonProperty("selementid")]
        public string? SelementId { get; set; }

        [JsonProperty("elementtype")]
        public int? ElementType { get; set; }

        [JsonProperty("iconid_off")]
        public string? IconIdOff { get; set; }

        [JsonProperty("areatype")]
        public int? AreaType { get; set; }

        [JsonProperty("elementsubtype")]
        public int? ElementSubtype { get; set; }

        [JsonProperty("evaltype")]
        public int? EvalType { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("iconid_disabled")]
        public string? IconIdDisabled { get; set; }

        [JsonProperty("iconid_maintenance")]
        public string? IconIdMaintenance { get; set; }

        [JsonProperty("iconid_on")]
        public string? IconIdOn { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("label_location")]
        public int? LabelLocation { get; set; }

        [JsonProperty("permission")]
        public int? Permission { get; set; }

        [JsonProperty("sysmapid")]
        public string? SysmapId { get; set; }

        [JsonProperty("use_iconmap")]
        public int? UseIconMap { get; set; }

        [JsonProperty("viewtype")]
        public int? ViewType { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("x")]
        public int? X { get; set; }

        [JsonProperty("y")]
        public int? Y { get; set; }

        #endregion

        #region Components

        [JsonProperty("elements")]
        public IList<ElementData>? Elements { get; set; }

        [JsonProperty("urls")]
        public IList<MapElementUrl>? Urls { get; set; }
        #endregion

        #region Constructors

        public MapElement(int elementType, string iconIdOff, IList<ElementData> elements)
        {
            ElementType = elementType;
            IconIdOff = iconIdOff;
            Elements = elements;
        }

        public MapElement() { }

        #endregion
    }

    public class ElementData
    {
        //TODO?
    }

    public class MapElementHost : ElementData
    {
        #region Properties

        [JsonProperty("hostid")]
        public string? HostId { get; set; }

        #endregion

    }

    public class MapElementHostGroup : ElementData
    {
        #region Properties

        [JsonProperty("groupid")]
        public string? GroupId { get; set; }

        #endregion

    }

    public class MapElementMap : ElementData
    {
        #region Properties

        [JsonProperty("sysmapid")]
        public string? SysmapId { get; set; }

        #endregion

    }

    public class MapElementTrigger : ElementData
    {
        #region Properties

        [JsonProperty("triggerid")]
        public string? TriggerId { get; set; }

        #endregion

    }

    public class MapElementTag : ElementData
    {
        #region Properties

        [JsonProperty("tag")]
        public string? TagName { get; set; }

        [JsonProperty("operator")]
        public int? ConditionOperator { get; set; }

        [JsonProperty("value")]
        public string? TagValue { get; set; }

        #endregion

        #region Constructors

        public MapElementTag(string? tagName)
        {
            TagName = tagName;
        }

        public MapElementTag() { }

        #endregion


    }

    public class MapElementUrl : ElementData
    {
        #region Properties

        [JsonProperty("sysmapelementurlid")]
        public string? SysmapElementUrlId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("selementid")]
        public string? SelemntId { get; set; }

        #endregion

        #region Constructors

        public MapElementUrl(string? name, string? url)
        {
            Name = name;
            Url = url;
        }

        public MapElementUrl() { }

        #endregion
    }
    public class MapLink
    {
        #region Properties

        [JsonProperty("linkid")]
        public string? LinkId { get; set; }

        [JsonProperty("selementid1")]
        public string? SElementId1 { get; set; }

        [JsonProperty("selementid2")]
        public string? SElementId2 { get; set; }

        [JsonProperty("color")]
        public string? LineColor { get; set; }

        [JsonProperty("drawtype")]
        public int? LineDrawStyle { get; set; }

        [JsonProperty("label")]
        public string? LinkLabel { get; set; }

        [JsonProperty("permission")]
        public int? PermissionLevel { get; set; }

        [JsonProperty("sysmapid")]
        public string? SysmapId { get; set; }
        #endregion

        #region Components

        [JsonProperty("linktriggers")]
        public IList<MapLinkTrigger>? LinkTriggers { get; set; }

        #endregion

        #region Constructors

        public MapLink(string sElementId1, string sElementId2)
        {
            SElementId1 = sElementId1;
            SElementId2 = sElementId2;
        }

        public MapLink() { }

        #endregion
}

public class MapLinkTrigger
    {
        #region Properties

        [JsonProperty("linktriggerid")]
        public string? LinkTriggerId { get; set; }

        [JsonProperty("triggerid")]
        public string? TriggerId { get; set; }

        [JsonProperty("color")]
        public string? IndicatorColor { get; set; }

        [JsonProperty("drawtype")]
        public int? IndicatorDrawStyle { get; set; }

        [JsonProperty("linkid")]
        public string? MapLinkId { get; set; }

        #endregion

        #region Constructors

        public MapLinkTrigger(string? triggerId)
        {
            TriggerId = triggerId;
        }

        public MapLinkTrigger() { }

        #endregion

    }

    public class MapUrl
    {
        #region Properties

        [JsonProperty("sysmapurlid")]
        public string? SysmapUrlId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }

        [JsonProperty("elementtype")]
        public int? ElementType { get; set; }

        [JsonProperty("sysmapid")]
        public string? SysmapId { get; set; }

        #endregion

        #region Constructors

        public MapUrl(string? name, string? url)
        {
            Name = name;
            Url = url;
        }

        public MapUrl() { }

        #endregion
    }

    public class MapUser
    {
        #region Properties

        [JsonProperty("sysmapuserid")]
        public string? SysmapUserId { get; set; }

        [JsonProperty("userid")]
        public string? UserId { get; set; }

        [JsonProperty("permission")]
        public int? PermissionLevel { get; set; }

        #endregion
    }

    public class MapUserGroup
    {
        #region Properties

        [JsonProperty("sysmapusrgrpid")]
        public string? SysmapUserGroupId { get; set; }

        [JsonProperty("usrgrpid")]
        public string? UserGroupId { get; set; }

        [JsonProperty("permission")]
        public int? PermissionLevel { get; set; }

        #endregion

        #region Constructors

        public MapUserGroup(string? userGroupId, int? permissionLevel)
        {
            UserGroupId = userGroupId;
            PermissionLevel = permissionLevel;
        }

        public MapUserGroup() { }

        #endregion

    }
    public class MapShape
    {
        #region Properties

        [JsonProperty("sysmap_shapeid")]
        public string? SysmapShapeId { get; set; }

        [JsonProperty("type")]
        public int? Type { get; set; }

        [JsonProperty("x")]
        public int? X { get; set; }

        [JsonProperty("y")]
        public int? Y { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("text")]
        public string? Text { get; set; }

        [JsonProperty("font")]
        public int? Font { get; set; }

        [JsonProperty("font_size")]
        public int? FontSize { get; set; }

        [JsonProperty("font_color")]
        public string? FontColor { get; set; }

        [JsonProperty("text_halign")]
        public int? TextHorizontalAlignment { get; set; }

        [JsonProperty("text_valign")]
        public int? TextVerticalAlignment { get; set; }

        [JsonProperty("border_type")]
        public int? BorderType { get; set; }

        [JsonProperty("border_width")]
        public int? BorderWidth { get; set; }

        [JsonProperty("border_color")]
        public string? BorderColor { get; set; }

        [JsonProperty("background_color")]
        public string? BackgroundColor { get; set; }

        [JsonProperty("zindex")]
        public int? ZIndex { get; set; }

        #endregion

        #region Constructors

        public MapShape(int? type)
        {
            Type = type;
        }

        public MapShape() { }

        #endregion

    }

    public class MapLine
    {
        #region Properties

        [JsonProperty("sysmap_shapeid")]
        public string? SysmapShapeId { get; set; }

        [JsonProperty("x1")]
        public int? X1 { get; set; }

        [JsonProperty("y1")]
        public int? Y1 { get; set; }

        [JsonProperty("x2")]
        public int? X2 { get; set; }

        [JsonProperty("y2")]
        public int? Y2 { get; set; }

        [JsonProperty("line_type")]
        public int? LineType { get; set; }

        [JsonProperty("line_width")]
        public int? LineWidth { get; set; }

        [JsonProperty("line_color")]
        public string? LineColor { get; set; }

        [JsonProperty("zindex")]
        public int? ZIndex { get; set; }

        #endregion

    }
}

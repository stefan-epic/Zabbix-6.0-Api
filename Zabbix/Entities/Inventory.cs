using Newtonsoft.Json;

namespace Zabbix.Entities
{

    public class Inventory : BaseEntitiy
    {
        #region Properties

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("asset_tag")]
        public string AssetTag { get; set; }

        [JsonProperty("chassis")]
        public string Chassis { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("contract_number")]
        public string ContractNumber { get; set; }

        [JsonProperty("date_hw_decomm")]
        public string DateHWDecomm { get; set; }

        [JsonProperty("date_hw_expiry")]
        public string DateHWExpiry { get; set; }

        [JsonProperty("date_hw_install")]
        public string DateHWInstall { get; set; }

        [JsonProperty("date_hw_purchase")]
        public string DateHWPurchase { get; set; }

        [JsonProperty("deployment_status")]
        public string DeploymentStatus { get; set; }

        [JsonProperty("hardware")]
        public string Hardware { get; set; }

        [JsonProperty("hardware_full")]
        public string HardwareFull { get; set; }

        [JsonProperty("host_netmask")]
        public string HostNetmask { get; set; }

        [JsonProperty("host_networks")]
        public string HostNetworks { get; set; }

        [JsonProperty("host_router")]
        public string HostRouter { get; set; }

        [JsonProperty("hw_arch")]
        public string HWArchitecture { get; set; }

        [JsonProperty("installer_name")]
        public string InstallerName { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("location_lat")]
        public string LocationLatitude { get; set; }

        [JsonProperty("location_lon")]
        public string LocationLongitude { get; set; }

        [JsonProperty("macaddress_a")]
        public string MacAddressA { get; set; }

        [JsonProperty("macaddress_b")]
        public string MacAddressB { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("oob_ip")]
        public string OOBIPAddress { get; set; }

        [JsonProperty("oob_netmask")]
        public string OOBHostNetmask { get; set; }

        [JsonProperty("oob_router")]
        public string OOBRouter { get; set; }

        [JsonProperty("os")]
        public string OS { get; set; }

        [JsonProperty("os_full")]
        public string OSFull { get; set; }

        [JsonProperty("os_short")]
        public string OSShort { get; set; }

        [JsonProperty("poc_1_cell")]
        public string PrimaryPOCMobileNumber { get; set; }

        [JsonProperty("poc_1_email")]
        public string PrimaryPOCEmail { get; set; }

        [JsonProperty("poc_1_name")]
        public string PrimaryPOCName { get; set; }

        [JsonProperty("poc_1_notes")]
        public string PrimaryPOCNotes { get; set; }

        [JsonProperty("poc_1_phone_a")]
        public string PrimaryPOCPhoneA { get; set; }

        [JsonProperty("poc_1_phone_b")]
        public string PrimaryPOCPhoneB { get; set; }

        [JsonProperty("poc_1_screen")]
        public string PrimaryPOCScreenName { get; set; }

        [JsonProperty("poc_2_cell")]
        public string SecondaryPOCMobileNumber { get; set; }

        [JsonProperty("poc_2_email")]
        public string SecondaryPOCEmail { get; set; }

        [JsonProperty("poc_2_name")]
        public string SecondaryPOCName { get; set; }

        [JsonProperty("poc_2_notes")]
        public string SecondaryPOCNotes { get; set; }

        [JsonProperty("poc_2_phone_a")]
        public string SecondaryPOCPhoneA { get; set; }

        [JsonProperty("poc_2_phone_b")]
        public string SecondaryPOCPhoneB { get; set; }

        [JsonProperty("poc_2_screen")]
        public string SecondaryPOCScreenName { get; set; }

        [JsonProperty("serialno_a")]
        public string SerialNumberA { get; set; }

        [JsonProperty("serialno_b")]
        public string SerialNumberB { get; set; }

        [JsonProperty("site_address_a")]
        public string SiteAddressA { get; set; }

        [JsonProperty("site_address_b")]
        public string SiteAddressB { get; set; }

        [JsonProperty("site_address_c")]
        public string SiteAddressC { get; set; }

        [JsonProperty("site_city")]
        public string SiteCity { get; set; }

        [JsonProperty("site_country")]
        public string SiteCountry { get; set; }

        [JsonProperty("site_notes")]
        public string SiteNotes { get; set; }

        [JsonProperty("site_rack")]
        public string SiteRackLocation { get; set; }

        [JsonProperty("site_state")]
        public string SiteState { get; set; }

        [JsonProperty("site_zip")]
        public string SiteZIP { get; set; }

        [JsonProperty("software")]
        public string Software { get; set; }

        [JsonProperty("software_app_a")]
        public string SoftwareApplicationA { get; set; }

        [JsonProperty("software_app_b")]
        public string SoftwareApplicationB { get; set; }

        [JsonProperty("software_app_c")]
        public string SoftwareApplicationC { get; set; }

        [JsonProperty("software_app_d")]
        public string SoftwareApplicationD { get; set; }

        [JsonProperty("software_app_e")]
        public string SoftwareApplicationE { get; set; }

        [JsonProperty("software_full")]
        public string SoftwareFull { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_full")]
        public string TypeDetails { get; set; }

        [JsonProperty("url_a")]
        public string URLA { get; set; }

        [JsonProperty("url_b")]
        public string URLB { get; set; }

        [JsonProperty("url_c")]
        public string URLC { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        #endregion Properties
    }
}
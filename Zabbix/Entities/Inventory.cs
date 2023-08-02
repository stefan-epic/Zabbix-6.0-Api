namespace Zabbix.Entities
{

    //TODO dont know if correct
    public class Inventory : IBaseEntitiy
    {
        #region Properties

        /// <summary>
        /// Alias.
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Asset tag.
        /// </summary>
        public string AssetTag { get; set; }

        /// <summary>
        /// Chassis.
        /// </summary>
        public string Chassis { get; set; }

        /// <summary>
        /// Contact person.
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// Contract number.
        /// </summary>
        public string ContractNumber { get; set; }

        /// <summary>
        /// HW decommissioning date.
        /// </summary>
        public string DateHwDecomm { get; set; }

        /// <summary>
        /// HW maintenance expiry date.
        /// </summary>
        public string DateHwExpiry { get; set; }

        /// <summary>
        /// HW installation date.
        /// </summary>
        public string DateHwInstall { get; set; }

        /// <summary>
        /// HW purchase date.
        /// </summary>
        public string DateHwPurchase { get; set; }

        /// <summary>
        /// Deployment status.
        /// </summary>
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// Hardware.
        /// </summary>
        public string Hardware { get; set; }

        /// <summary>
        /// Detailed hardware.
        /// </summary>
        public string HardwareFull { get; set; }

        /// <summary>
        /// Host subnet mask.
        /// </summary>
        public string HostNetmask { get; set; }

        /// <summary>
        /// Host networks.
        /// </summary>
        public string HostNetworks { get; set; }

        /// <summary>
        /// Host router.
        /// </summary>
        public string HostRouter { get; set; }


        /// <summary>
        /// HW architecture.

        /// </summary>
        public string HwArch { get; set; }

        /// <summary>
        /// Installer name.
        /// </summary>
        public string InstallerName { get; set; }

        /// <summary>
        /// Location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Location latitude.
        /// </summary>
        public string LocationLat { get; set; }

        /// <summary>
        /// Location longitude.
        /// </summary>
        public string LocationLon { get; set; }

        /// <summary>
        /// MAC address A.
        /// </summary>
        public string MacaddressA { get; set; }

        /// <summary>
        /// MAC address B.
        /// </summary>
        public string MacaddressB { get; set; }

        /// <summary>
        /// Model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// OOB IP address.
        /// </summary>
        public string OobIp { get; set; }

        /// <summary>
        /// OOB host subnet mask.
        /// </summary>
        public string OobNetmask { get; set; }

        /// <summary>
        /// OOB router.
        /// </summary>
        public string OobRouter { get; set; }

        /// <summary>
        /// OS name.
        /// </summary>
        public string Os { get; set; }

        /// <summary>
        /// Detailed OS name.
        /// </summary>
        public string OsFull { get; set; }

        /// <summary>
        /// Short OS name.
        /// </summary>
        public string OsShort { get; set; }

        /// <summary>
        /// Primary POC mobile number.
        /// </summary>
        public string Poc1Cell { get; set; }

        /// <summary>
        /// Primary email.
        /// </summary>
        public string Poc1Email { get; set; }

        /// <summary>
        /// Primary POC name.
        /// </summary>
        public string Poc1Name { get; set; }

        /// <summary>
        /// Primary POC notes.
        /// </summary>
        public string Poc1Notes { get; set; }

        /// <summary>
        /// Primary POC phone A.
        /// </summary>
        public string Poc1PhoneA { get; set; }

        /// <summary>
        /// Primary POC phone B.
        /// </summary>
        public string Poc1PhoneB { get; set; }

        /// <summary>
        /// Primary POC screen name.
        /// </summary>
        public string Poc1Screen { get; set; }

        /// <summary>
        /// Secondary POC mobile number.
        /// </summary>
        public string Poc2Cell { get; set; }

        /// <summary>
        /// Secondary POC email.
        /// </summary>
        public string Poc2Email { get; set; }

        /// <summary>
        /// Secondary POC name.
        /// </summary>
        public string Poc2Name { get; set; }

        /// <summary>
        /// Secondary POC notes.
        /// </summary>
        public string Poc2Notes { get; set; }

        /// <summary>
        /// Secondary POC phone A.
        /// </summary>
        public string Poc2PhoneA { get; set; }

        /// <summary>
        /// Secondary POC phone B.
        /// </summary>
        public string Poc2PhoneB { get; set; }

        /// <summary>
        /// Secondary POC screen name.
        /// </summary>
        public string Poc2Screen { get; set; }

        /// <summary>
        /// Serial number A.
        /// </summary>
        public string SerialnoA { get; set; }

        /// <summary>
        /// Serial number B.
        /// </summary>
        public string SerialnoB { get; set; }

        /// <summary>
        /// Site address A.
        /// </summary>
        public string SiteAddressA { get; set; }

        /// <summary>
        /// Site address B.
        /// </summary>
        public string SiteAddressB { get; set; }

        /// <summary>
        /// Site address C.
        /// </summary>
        public string SiteAddressC { get; set; }

        /// <summary>
        /// Site city.
        /// </summary>
        public string SiteCity { get; set; }

        /// <summary>
        /// Site country.
        /// </summary>
        public string SiteCountry { get; set; }

        /// <summary>
        /// Site notes.
        /// </summary>
        public string SiteNotes { get; set; }

        /// <summary>
        /// Site rack location.
        /// </summary>
        public string SiteRack { get; set; }

        /// <summary>
        /// Site state.
        /// </summary>
        public string SiteState { get; set; }

        /// <summary>
        /// Site ZIP/postal code.
        /// </summary>
        public string SiteZip { get; set; }

        /// <summary>
        /// Software.
        /// </summary>
        public string Software { get; set; }

        /// <summary>
        /// Software application A.
        /// </summary>
        public string SoftwareAppA { get; set; }

        /// <summary>
        /// Software application B.
        /// </summary>
        public string SoftwareAppB { get; set; }

        /// <summary>
        /// Software application C.
        /// </summary>
        public string SoftwareAppC { get; set; }

        /// <summary>
        /// Software application D.
        /// </summary>
        public string SoftwareAppD { get; set; }

        /// <summary>
        /// Software application E.
        /// </summary>
        public string SoftwareAppE { get; set; }

        /// <summary>
        /// Software details.
        /// </summary>
        public string SoftwareFull { get; set; }

        /// <summary>
        /// TagName.
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Type details.
        /// </summary>
        public string TypeFull { get; set; }

        /// <summary>
        /// URL A.
        /// </summary>
        public string UrlA { get; set; }

        /// <summary>
        /// URL B.
        /// </summary>
        public string UrlB { get; set; }

        /// <summary>
        /// URL C.
        /// </summary>
        public string UrlC { get; set; }

        /// <summary>
        /// Vendor.
        /// </summary>
        public string Vendor { get; set; }

        #endregion Properties
    }
}
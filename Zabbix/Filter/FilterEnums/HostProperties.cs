using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Filter.FilterEnums
{
    public enum HostProperties
    {
        hostid,
        proxy_hostid,
        host,
        status,
        lastaccess,
        ipmi_authtype,
        ipmi_privilege,
        ipmi_username,
        ipmi_password,
        maintenanceid,
        maintenance_status,
        maintenance_type,
        maintenance_from,
        name,
        flags,
        description,
        tls_connect,
        tls_accept,
        tls_issuer,
        tls_subject,
        inventory_mode
    }
}
﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public enum AutoregistrationProperties
    {
        tls_accept,
        tls_psk_identity,
        tls_psk
    }
    public class Autoregistration : BaseEntity
    {
        [JsonProperty("tls_accept")]
        public int? TlsAccept { get; set; }

        [JsonProperty("tls_psk_identity")]
        public string? TlsPskIdentity { get; set; }

        [JsonProperty("tls_psk")]
        public string? TlsPsk { get; set; }
    }
}

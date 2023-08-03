using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabbix.Entities
{
    public class Authentication : BaseEntitiy
    {
        #region Properties
        [JsonProperty("authentication_type")]
        public string AuthenticationType { get; set; }

        [JsonProperty("http_auth_enabled")]
        public string HttpAuthEnabled { get; set; }

        [JsonProperty("http_login_form")]
        public string HttpLoginForm { get; set; }

        [JsonProperty("http_strip_domains")]
        public string HttpStripDomains { get; set; }

        [JsonProperty("http_case_sensitive")]
        public string HttpCaseSensitive { get; set; }

        [JsonProperty("ldap_configured")]
        public string LdapConfigured { get; set; }

        [JsonProperty("ldap_host")]
        public string LdapHost { get; set; }

        [JsonProperty("ldap_port")]
        public string LdapPort { get; set; }

        [JsonProperty("ldap_base_dn")]
        public string LdapBaseDn { get; set; }

        [JsonProperty("ldap_search_attribute")]
        public string LdapSearchAttribute { get; set; }

        [JsonProperty("ldap_bind_dn")]
        public string LdapBindDn { get; set; }

        [JsonProperty("ldap_case_sensitive")]
        public string LdapCaseSensitive { get; set; }

        [JsonProperty("ldap_bind_password")]
        public string LdapBindPassword { get; set; }

        [JsonProperty("saml_auth_enabled")]
        public string SamlAuthEnabled { get; set; }

        [JsonProperty("saml_idp_entityid")]
        public string SamlIdpEntityid { get; set; }

        [JsonProperty("saml_sso_url")]
        public string SamlSsoUrl { get; set; }

        [JsonProperty("saml_slo_url")]
        public string SamlSloUrl { get; set; }

        [JsonProperty("saml_username_attribute")]
        public string SamlUsernameAttribute { get; set; }

        [JsonProperty("saml_sp_entityid")]
        public string SamlSpEntityid { get; set; }

        [JsonProperty("saml_nameid_format")]
        public string SamlNameidFormat { get; set; }

        [JsonProperty("saml_sign_messages")]
        public string SamlSignMessages { get; set; }

        [JsonProperty("saml_sign_assertions")]
        public string SamlSignAssertions { get; set; }

        [JsonProperty("saml_sign_authn_requests")]
        public string SamlSignAuthnRequests { get; set; }

        [JsonProperty("saml_sign_logout_requests")]
        public string SamlSignLogoutRequests { get; set; }

        [JsonProperty("saml_sign_logout_responses")]
        public string SamlSignLogoutResponses { get; set; }

        [JsonProperty("saml_encrypt_nameid")]
        public string SamlEncryptNameid { get; set; }

        [JsonProperty("saml_encrypt_assertions")]
        public string SamlEncryptAssertions { get; set; }

        [JsonProperty("saml_case_sensitive")]
        public string SamlCaseSensitive { get; set; }

        [JsonProperty("passwd_min_length")]
        public string PasswdMinLength { get; set; }

        [JsonProperty("passwd_check_rules")]
        public string PasswdCheckRules { get; set; }


        #endregion

    }
}

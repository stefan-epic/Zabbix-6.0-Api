using Newtonsoft.Json;

namespace Zabbix.Entities;

//this doesnt have an id TODO
public enum AuthenticationProperties
{
}

public class Authentication : BaseEntitiy
{
    #region Properties

    [JsonProperty("authentication_type")] public int? AuthenticationType { get; set; }

    [JsonProperty("http_auth_enabled")] public int? HttpAuthEnabled { get; set; }

    [JsonProperty("http_login_form")] public int? HttpLoginForm { get; set; }

    [JsonProperty("http_strip_domains")] public string? HttpStripDomains { get; set; }

    [JsonProperty("http_case_sensitive")] public int? HttpCaseSensitive { get; set; }

    [JsonProperty("ldap_configured")] public int? LdapConfigured { get; set; }

    [JsonProperty("ldap_host")] public string? LdapHost { get; set; }

    [JsonProperty("ldap_port")] public int? LdapPort { get; set; }

    [JsonProperty("ldap_base_dn")] public int? LdapBaseDn { get; set; }

    [JsonProperty("ldap_search_attribute")]
    public int? LdapSearchAttribute { get; set; }

    [JsonProperty("ldap_bind_dn")] public int? LdapBindDn { get; set; }

    [JsonProperty("ldap_case_sensitive")] public int? LdapCaseSensitive { get; set; }

    [JsonProperty("ldap_bind_password")] public string? LdapBindPassword { get; set; }

    [JsonProperty("saml_auth_enabled")] public int? SamlAuthEnabled { get; set; }

    [JsonProperty("saml_idp_entityid")] public string? SamlIdpEntityid { get; set; }

    [JsonProperty("saml_sso_url")] public string? SamlSsoUrl { get; set; }

    [JsonProperty("saml_slo_url")] public string? SamlSloUrl { get; set; }

    [JsonProperty("saml_username_attribute")]
    public string? SamlUsernameAttribute { get; set; }

    [JsonProperty("saml_sp_entityid")] public string? SamlSpEntityid { get; set; }

    [JsonProperty("saml_nameid_format")] public string? SamlNameidFormat { get; set; }

    [JsonProperty("saml_sign_messages")] public int? SamlSignMessages { get; set; }

    [JsonProperty("saml_sign_assertions")] public int? SamlSignAssertions { get; set; }

    [JsonProperty("saml_sign_authn_requests")]
    public int? SamlSignAuthnRequests { get; set; }

    [JsonProperty("saml_sign_logout_requests")]
    public int? SamlSignLogoutRequests { get; set; }

    [JsonProperty("saml_sign_logout_responses")]
    public int? SamlSignLogoutResponses { get; set; }

    [JsonProperty("saml_encrypt_nameid")] public int? SamlEncryptNameid { get; set; }

    [JsonProperty("saml_encrypt_assertions")]
    public int? SamlEncryptAssertions { get; set; }

    [JsonProperty("saml_case_sensitive")] public int? SamlCaseSensitive { get; set; }

    [JsonProperty("passwd_min_length")] public int? PasswdMinLength { get; set; }

    [JsonProperty("passwd_check_rules")] public int? PasswdCheckRules { get; set; }

    #endregion
}
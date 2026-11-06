using SPID.AspNetCore.Authentication.Models;
using System.Security.Cryptography.X509Certificates;

namespace SPID.AspNetCore.Authentication.Events
{
    public sealed class SecurityTokenCreatingOptions
    {
        /// <summary>Optional application correlation reference; must fit SAML's 80-byte limit.</summary>
        public string? RelayState { get; set; }
        public string EntityId { get; set; }
        public string AssertionConsumerServiceURL { get; set; }
        public ushort? AssertionConsumerServiceIndex { get; set; }
        public ushort AttributeConsumingServiceIndex { get; set; }
        public X509Certificate2 Certificate { get; set; }
        public int SecurityLevel { get; set; }
        public RequestMethod RequestMethod { get; set; }
    }
}

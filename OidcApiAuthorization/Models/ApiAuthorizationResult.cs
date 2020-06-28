using System.Collections.Generic;
using System.Security.Claims;

namespace OidcApiAuthorization.Models
{
    /// <summary>
    /// Encapsulates the results of an API authorization.
    /// </summary>
    public class ApiAuthorizationResult
    {
        /// <summary>
        /// Constructs a success authorization.
        /// </summary>
        /// <param name="claims">
        /// The claims from the validated JWT token.
        /// </param>
        public ApiAuthorizationResult(IEnumerable<Claim> claims)
        {
            Claims = claims;
        }

        /// <summary>
        /// Constructs a failed authorization with given reason.
        /// </summary>
        /// <param name="failureReason">
        /// Describes the reason for the authorization failure.
        /// </param>
        public ApiAuthorizationResult(string failureReason)
        {
            FailureReason = failureReason;
        }

        /// <summary>
        /// The claims from the validated JWT token.
        /// Empty list of no claims, or validation failed.
        /// </summary>
        public IEnumerable<Claim> Claims { get; set; } = new List<Claim>();

        /// <summary>
        /// True if authorization failed.
        /// </summary>
        public bool Failed => FailureReason != null;

        /// <summary>
        /// String describing the reason for the authorization failure.
        /// </summary>
        public string FailureReason { get; }

        /// <summary>
        /// True if authorization was successful.
        /// </summary>
        public bool Success => !Failed;
    }
}

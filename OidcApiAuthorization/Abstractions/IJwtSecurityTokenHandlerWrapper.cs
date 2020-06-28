using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace OidcApiAuthorization.Abstractions
{
    public interface IJwtSecurityTokenHandlerWrapper
    {
        IEnumerable<Claim> ValidateToken(string token, TokenValidationParameters tokenValidationParameters);
    }
}

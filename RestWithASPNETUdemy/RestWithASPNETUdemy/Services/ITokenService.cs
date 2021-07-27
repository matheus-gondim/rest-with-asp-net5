using System.Collections.Generic;
using System.Security.Claims;

namespace RestWithASPNETUdemy.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerareRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}

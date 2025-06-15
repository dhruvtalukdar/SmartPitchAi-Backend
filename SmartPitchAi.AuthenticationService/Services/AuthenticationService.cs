using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SmartPitchAi.Application.Interfaces.Services;

namespace SmartPitchAi.AuthenticationService.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _configuration;
        private readonly string _authority;
        private readonly string _signingKey;
        private readonly string _audience;
        private readonly IMemoryCache _cache;

        public string GenerateAuthenticationToken(string userId)
        {
            throw new NotImplementedException();
        }

        public bool IsTokenExists(string token)
        {
            throw new NotImplementedException();
        }
    }
}

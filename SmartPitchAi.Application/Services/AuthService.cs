using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SmartPitchAi.Application.DTOs.Auth;
using SmartPitchAi.Application.Interfaces.Services;
using SmartPitchAi.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace SmartPitchAi.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _config;

        public AuthService(UserManager<ApplicationUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        async Task<AuthResult> IAuthService.RegisterAsync(RegisterRequest request)
        {
            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                FullName = request.FullName
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors);
                throw new ApplicationException($"Registration failed: {errors}");
            }

            var token = GenerateJwtToken(user);
            return new AuthResult { Token = token, UserId = user.Id, Email = user.Email };

        }

        Task<AuthResult> IAuthService.LoginAsync(LoginRequest request)
        {
            throw new NotImplementedException();
        }


        // private methods
        //private string GenerateJwtToken(ApplicationUser user)
        //{
        //    var key = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
        //    var creds = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256);

        //    var claims = new List<Claim>
        //    {
        //        new(ClaimTypes.NameIdentifier, user.Id),
        //        new(JwtRegisteredClaimNames.Sub, user.Email),
        //        new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //    };

        //    var token = new JwtSecurityToken(
        //        issuer: _config["Jwt:Issuer"],
        //        audience: _config["Jwt:Issuer"],
        //        claims: claims,
        //        expires: DateTime.UtcNow.AddDays(7),
        //        signingCredentials: creds
        //    );

        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}
    }
}

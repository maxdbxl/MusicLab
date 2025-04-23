using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using MusicLab.Application.Interfaces.Security;

namespace MusicLab.Application.Security
{
    public class TokenManager(TokenManager.Config config) : ITokenManager
    {
        public class Config
        {
            public string Secret { get; set; } = null!;
            public int Duration { get; set; } // en secondes
            public string Issuer { get; set; } = null!;
            public string Audience { get; set; } = null!;

        }

        public string CreateToken(int id, string email, string role)
        {
            JwtSecurityTokenHandler handler = new();
            JwtSecurityToken token = new(
                config.Issuer,
                config.Audience,
                CreateClaims(id, email, role),
                DateTime.Now,
                DateTime.Now.AddSeconds(config.Duration),
                new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.Secret)),
                    SecurityAlgorithms.HmacSha256
                )
            );
            return handler.WriteToken( token );
        }

        private IEnumerable<Claim> CreateClaims(int id, string email, string role)
        {
            yield return new Claim(ClaimTypes.Email, email);
            yield return new Claim(ClaimTypes.Role, role);
            yield return new Claim(ClaimTypes.NameIdentifier, id.ToString(), ClaimValueTypes.Integer32);
        }

        public int ValidateTokenWithoutLifetime(string token)
        {
            throw new NotImplementedException();
        }
    }
}

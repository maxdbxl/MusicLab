using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Security;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Application.Security;
using MusicLab.Domain.Entities;

namespace MusicLab.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthController(IAuthService authService, ITokenManager tokenManager) : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginFormDTO dto)
        {
            // Se connecter à la DB
            // Chercher user avec username correspondant
            Member? m = authService.Login(dto);
            
            // Si user pas trouvé, 400 ou 401
            if (m is null)
            {
                return BadRequest();
            }
            // Si user trouvé
                // Vérifier MDP
                    // Si pas correct, 400 ou 401
                    // si correct, créer token et le renvoyer
            return authService.CheckPassword(dto.Password, m.Salt, m.Password) ? 
                Ok(
                    new { Token = tokenManager.CreateToken(m.Id, m.Email, m.Password)}
                
                ) : BadRequest();
            
            
        }

        [HttpGet("refreshToken")]
        public IActionResult RefreshToken([FromQuery]string token)
        {
            int id = tokenManager.ValidateTokenWithoutLifetime(token);
        }
    }
}

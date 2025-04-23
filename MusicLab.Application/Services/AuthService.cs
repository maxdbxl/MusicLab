using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Application.Utils;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Services
{
    public class AuthService(IAuthRepository authRepository) : IAuthService
    {
        public Member? Login(LoginFormDTO dto)
        {
            Member? m = authRepository.Login(dto);
            return m;
        }

        public bool CheckPassword(string password, Guid salt, string dbPassword)
        {
            if (PasswordUtils.HashPassword(password, salt) != dbPassword)
            {
                return false;
            }
            return true;
        }
    }
}

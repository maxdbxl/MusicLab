using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Member? Login(LoginFormDTO dto);

        bool CheckPassword(string password, Guid salt, string dbPassword);
    }
}

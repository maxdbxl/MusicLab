using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface IAuthRepository
    {
        Member? Login(LoginFormDTO dto);
    }
}

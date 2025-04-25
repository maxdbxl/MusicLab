using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Repositories
{
    public class AuthRepository(MusicLabContext ctx) : IAuthRepository
    {
       

        public Member? Login(LoginFormDTO dto)
        {
            return ctx.Members.SingleOrDefault(m => m.Username == dto.Username);
        }
        
        public Member? FindById(int id)
        {
            return ctx.Members.SingleOrDefault(m => m.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Enums;

namespace MusicLab.Application.DTO
{
    public class RegisterMemberDTO
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        //public Role Role { get; set; }
    }
}

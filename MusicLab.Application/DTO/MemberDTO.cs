using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.DTO
{
    public class MemberDTO(Member m)
    {
        public int Id { get; set; } = m.Id;
        public string Username { get; set; } = m.Username;
        public string Email { get; set; } = m.Email;

        
    }
}

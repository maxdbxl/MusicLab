using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Enums;

namespace MusicLab.Domain.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public Guid Salt { get; set; }
        public Role Role { get; set; }
        public List<Company> Companies { get; set; } = null!;
        public List<Project> OwnedProjects { get; set; } = null!;
        public List<Invitation> Invitations { get; set; } = null!;

        public List<PersonalEvent> PersonalEvents { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Enums;

namespace MusicLab.Domain.Entities
{
    public class Invitation
    {
        public List<Meeting> Meetings { get; set; } = null!;
        public List<Member> Members { get; set; } = null!;
        
        public Availability Availability { get; set; }
    }
}

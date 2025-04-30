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
        public int Id { get; set; }

        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; } = null!;

        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;
        
        public Availability Availability { get; set; }
    }
}

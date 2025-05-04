using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLab.Application.DTO
{
    public class ChangeAvailabilityRequestDTO
    {
        public int MemberId { get; set; }
        public int MeetingId { get; set; }
        public string Availability { get; set; } = null!;
        
    }
}

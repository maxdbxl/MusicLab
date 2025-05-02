using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;
using MusicLab.Domain.Enums;

namespace MusicLab.Application.DTO
{
    public class CreateInvitationDTO
    {
        //public int MeetingId { get; set; }

        public int MemberId { get; set; }

        public Availability Availability { get; set; }

    }
}

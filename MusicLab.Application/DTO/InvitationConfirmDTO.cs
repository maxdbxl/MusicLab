using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;
using MusicLab.Domain.Enums;

namespace MusicLab.Application.DTO
{
    public class InvitationConfirmDTO(Invitation i)
    {

        public int Id { get; set; } = i.Id;

        public int MeetingId { get; set; } = i.MeetingId;
        public string MeetingName { get; set; } = i.Meeting.Name;

        public int MemberId { get; set; } = i.MemberId;
        public MemberDTO Member { get; set; } = new MemberDTO(i.Member);

        public Availability Availability { get; set; } = i.Availability;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Services
{
    public interface IMemberService
    {
        Member Create(RegisterMemberDTO dto);

        bool ExistsEmail(string email);
        bool ExistsUsername(string username);

        Member GetById(int id);
        List<Member> GetAll();

        List<Invitation> GetMembersAndInvitationsByMeetingId(int meetingId);

    }
}

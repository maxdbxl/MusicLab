using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface IMemberRepository
    {
        Member Add(Member m);

        bool EmailExists(string email);
        bool UsernameExists(string username);
        Member? GetMemberById(int Id);

        List<Member> GetAll();

        List<Invitation> GetMembersAndInvitationsByMeetingId(int meetingId);
        bool ChangeAvailibility(int memberId, int meetingId, string availability);
    }
}

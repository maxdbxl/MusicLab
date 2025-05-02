using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Repositories
{
    public class MeetingRepository(MusicLabContext ctx) : IMeetingRepository
    {
        public Meeting Add(Meeting m)
        {
            ctx.Meetings.Add(m);
            ctx.SaveChanges();
            return m;
        }

        public List<Meeting> GetMeetingsByMemberId(int memberId)
        {
            return ctx.Invitations.Where(i => i.MemberId == memberId && i.Availability != Domain.Enums.Availability.Unavailable).Select(i => i.Meeting).ToList();
        }

    }
}

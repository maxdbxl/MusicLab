using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface IMeetingRepository
    {
        Meeting Add(Meeting m);
        List<Meeting> GetMeetingsByMemberId(int memberId);
        List<Meeting> GetNextTenMeetingsByProjectId(int id);
    }
}

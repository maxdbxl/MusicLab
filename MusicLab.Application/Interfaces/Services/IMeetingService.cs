using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Services
{
    public interface IMeetingService
    {
        List<Meeting> GetMeetingsByMemberId(int memberId);

        Meeting Create(CreateMeetingDTO dto, int ownerId);
        List<Meeting> GetNextTenMeetingsByProjectId(int id);
    }
}

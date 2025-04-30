using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Services
{
    public interface IPersonalEventService
    {
        
        List<PersonalEvent> GetEventsByMemberId(int memberId);
    }
}

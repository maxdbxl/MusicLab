using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Services
{
    public class PersonalEventService(IPersonalEventRepository personalEventRepository) : IPersonalEventService
    {
        public List<PersonalEvent> GetEventsByMemberId(int memberId)
        {
            return personalEventRepository.GetAllPersonalEventsByMemberId(memberId);


        }
    }
}

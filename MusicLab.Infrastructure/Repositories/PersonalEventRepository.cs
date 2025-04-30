using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Repositories
{
    public class PersonalEventRepository(MusicLabContext ctx) : IPersonalEventRepository
    {
        public List<PersonalEvent> GetAllPersonalEventsByMemberId(int memberId)
        {
            return ctx.PersonalEvents.Where(pe =>  pe.MemberId == memberId).ToList();
        }
    }
}

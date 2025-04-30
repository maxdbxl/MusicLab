using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface IPersonalEventRepository
    {
        List<PersonalEvent> GetAllPersonalEventsByMemberId(int memberId);
    }
}

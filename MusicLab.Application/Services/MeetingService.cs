using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;

namespace MusicLab.Application.Services
{
    public class MeetingService (IMeetingRepository meetingRepository) : IMeetingService
    {
    }
}

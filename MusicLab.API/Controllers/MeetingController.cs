using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.Application.Interfaces.Services;

namespace MusicLab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController (IMeetingService meetingService) : ControllerBase
    {
    }
}

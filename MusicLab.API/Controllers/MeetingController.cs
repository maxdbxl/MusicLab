using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.API.Extensions;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController (IMeetingService meetingService, IPersonalEventService personalEventService) : ControllerBase
    {

        // Deux requêtes, meeting service et personaleventsServices
        // union :=> renvoi de la liste d'objets EventDTO (id, nom, etc.)

        [HttpGet]
        [Authorize]
        public IActionResult GetMeetingsByMemberId()
        {
   
                try
                {
                    List<Meeting> mEvents = meetingService.GetMeetingsByMemberId(User.GetId());
                    List<PersonalEvent> peEvents = personalEventService.GetEventsByMemberId(User.GetId());

                    List<EventDTO> events = [
                        ..peEvents.Select(pe => new EventDTO(pe)),
                        ..mEvents.Select(m => new EventDTO(m))
                        ];

                    return Ok(events);
                }
                catch (KeyNotFoundException) 
                {
                    return NotFound();
                }

            
        }
    }
}

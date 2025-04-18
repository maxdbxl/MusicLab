using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(IProjectService projectService) : ControllerBase
    {

        [HttpPost]
        public IActionResult Post([FromBody]CreateProjectDTO dto)
        {
            Project p = projectService.Create(dto);
            return Created("project/" + p.Id, p);
        }

    }
}

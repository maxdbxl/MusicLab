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
    public class ProjectController(IProjectService projectService) : ControllerBase
    {

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromBody] CreateProjectDTO dto)
        {
            Project p = projectService.Create(dto, User.GetId());
            return Created();
        }

        [HttpHead]
        public IActionResult ExistsProject([FromQuery] string projectName)
        {
            if (projectName != null)
            {
                if (projectService.ExistsProject(projectName)) {
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Project> allProjects = projectService.GetAll();
            return Ok(allProjects);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                Project? projectToGet = projectService.GetById(id);
                return Ok(projectToGet);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }
    }
}

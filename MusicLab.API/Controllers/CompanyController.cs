using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController(ICompanyService companyService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody]CreateCompanyDTO dto)
        {
            Company c = companyService.Create(dto);
            return Created("company/" + c.Id, c);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        { 
            try
            {
                Company? groupToGet = companyService.GetById(id);
                return Ok(groupToGet);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> allGroups = companyService.GetAll();
                return Ok(allGroups);
            //TODO : Try Catch + return NotFound
        }
    }
}

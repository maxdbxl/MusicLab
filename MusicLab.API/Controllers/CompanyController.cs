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
    }
}

using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using MusicLab.API.Extensions;
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
        //[Authorize]
        public IActionResult Get([FromRoute] int id)
        { 
      
            try
            {
                CompanyDTO? groupToGet = new CompanyDTO(companyService.GetById(id, User.GetId()));
                return Ok(groupToGet);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        //[Authorize]
        public IActionResult GetAll([FromQuery]int? memberId)
        {
            if (memberId != null)
            {
                //.VALUE pour préciser que pas null 
                List<Company> allGroupsByMemberId = companyService.GetAllByMemberId(memberId.Value);
                return Ok(allGroupsByMemberId);
            }
            List<Company> allGroups = companyService.GetAll();
                return Ok(allGroups);
            //TODO : Try Catch + return NotFound
        }

        [HttpPatch("{id}")]
        public IActionResult UpdateMemberList(int id,[FromQuery]JsonPatchDocument<Company> companyPatchDoc)
        {
            if (companyPatchDoc == null)
            {
                return BadRequest();
            }
            Company? company = companyService.GetCompanyByIdWithMembers(id);

            if (company == null) 
            {
                return NotFound();
            }
            companyPatchDoc.ApplyTo(company, ModelState);

            if (!TryValidateModel(company))
            {
                return BadRequest(ModelState);
            }



            return Ok(company);
        }

        [HttpPatch("{companyId}/members/{memberId}")]
        public IActionResult AddMemberToCompany(int companyId, int memberId)
        {
            // patch qui renseigne dans Body l'id du member à ajouter, soit prénom et nom pour créer membre et que ça l'ajoute

            try
            {
                    companyService.AddMemberToCompany(companyId, memberId);
                    return NoContent();
            } 
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

            
        }

        [HttpHead]
        public IActionResult Head([FromQuery] string groupName)
        {
            if (groupName != null)
            {
                if (companyService.ExistsGroup(groupName))
                {
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest();
        }
    }
}

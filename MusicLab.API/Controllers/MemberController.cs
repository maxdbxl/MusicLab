using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Application.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController(IMemberService memberService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody]RegisterMemberDTO dto)
        {
            Member m = memberService.Create(dto);
            return Created("member/" + m.Id, m);
        }

        [HttpHead]
        public IActionResult Head([FromQuery] string? email, [FromQuery] string? username)
        {
            if (email != null) { 
            
            
            if (memberService.ExistsEmail(email))
            {
                return Ok();
            }
            return NotFound();
        }
            if (username != null)
            {
                if (memberService.ExistsUsername(username))
                {
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest();
        } 
       


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            //Vérifier si le membre avec cette id existe
            //TODO : Ajout Autres Exceptions éventuelles
            //TODO : Ajout DTO pour le return
            try
            {
                Member? memberToGet = memberService.GetById(id);
                return Ok(memberToGet);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }          
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<MemberDTO> allMembers = memberService.GetAll().Select(m => new MemberDTO(m))
            .ToList();
            return Ok(allMembers);
        }


    }
}

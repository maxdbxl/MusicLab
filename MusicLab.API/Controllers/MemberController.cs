using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Services;
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
    }
}

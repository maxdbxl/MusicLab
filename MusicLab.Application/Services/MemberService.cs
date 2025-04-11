using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Services
{
    public class MemberService(IMemberRepository memberRepository) : IMemberService
    {
        public Member Create(RegisterMemberDTO dto)
        {
            Member m = memberRepository.Add(
                new Member
                {
                    Username = dto.Username,
                    Email = dto.Email,
                    Password = dto.Password,
                    Role = 0
                });
            return m;
        }

        public bool ExistsEmail(string email)
        {
            return memberRepository.EmailExists(email);
        }

        public Member GetById(int id)
        {
            return memberRepository.GetMemberById(id) ?? throw new KeyNotFoundException();
             
        }
    }
}

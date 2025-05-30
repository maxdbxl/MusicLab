﻿using System;
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
        public bool ExistsUsername(string username)
        {
            return memberRepository.UsernameExists(username);
        }

        public Member GetById(int id)
        {
            return memberRepository.GetMemberById(id) ?? throw new KeyNotFoundException();
             
        }

        public List<Member> GetAll()
        {
            return memberRepository.GetAll();
        }

        public List<Invitation> GetMembersAndInvitationsByMeetingId(int meetingId)
        {
            return memberRepository.GetMembersAndInvitationsByMeetingId(meetingId);
        }

        public bool ChangeAvailibility(int memberId, int meetingId, string availability)
        {
            Member? member = memberRepository.GetMemberById(memberId);
            if (member == null)
            {
                return false;
            }
            if (member.Id == memberId)
            {
                memberRepository.ChangeAvailibility(memberId, meetingId, availability);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

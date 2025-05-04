using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;
using MusicLab.Domain.Enums;

namespace MusicLab.Infrastructure.Repositories
{
    public class MemberRepository(MusicLabContext ctx) : IMemberRepository
    {
        public Member Add(Member m)
        {
            ctx.Members.Add(m);
            ctx.SaveChanges();
            return m;
        } 

        public bool EmailExists(string email)
        {
            return ctx.Members.Any(m => m.Email == email);
        }
        public bool UsernameExists(string username)
        {
            return ctx.Members.Any(m => m.Username == username);
        }

        public Member? GetMemberById(int id)
        {
            return ctx.Members.SingleOrDefault(m => m.Id == id);
        }

        public List<Member> GetAll()
        {
            return ctx.Members.ToList();
            //Faire join pour récupérer infos

        }

        public List<Invitation> GetMembersAndInvitationsByMeetingId(int meetingId)
        {
            return ctx.Invitations.Where(i => i.MeetingId == meetingId).Include(i => i.Member).Include(i => i.Meeting).ToList();

                
        }

        public bool ChangeAvailibility(int memberId, int meetingId, string availability)
        {

            Invitation? invitationToUpdate = ctx.Invitations.SingleOrDefault(i => i.MeetingId == meetingId && i.MemberId == memberId);

            if (invitationToUpdate == null)
            {
                return false;
            }
            if (availability == Availability.Available.ToString())
            {
                invitationToUpdate.Availability = Availability.Available;
            }
            else if (availability == Availability.Unavailable.ToString())
            {
                invitationToUpdate.Availability = Availability.Unavailable;
            } else
            {
                return false;
            }

            ctx.SaveChanges();
            return true;
                
        }

        //public List<Member> GetAllByProjectId(int groupId, int projectId)
        //{
        //    //return ctx.Members.Include(m => m.Companies).Include(m => m.Projects).Any()
        //}

    }
}

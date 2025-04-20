using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;

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

        
    }
}

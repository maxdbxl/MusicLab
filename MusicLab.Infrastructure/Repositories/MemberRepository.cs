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
        public virtual Member Add(Member m)
        {
            ctx.Members.Add(m);
            ctx.SaveChanges();
            return m;
        } 
    }
}

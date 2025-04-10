using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface IMemberRepository
    {
        Member Add(Member m);

        bool EmailExists(string email);

        Member? GetMemberById(int Id);
    }
}

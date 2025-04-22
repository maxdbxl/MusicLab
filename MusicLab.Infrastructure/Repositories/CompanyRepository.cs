using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Repositories
{
    public class CompanyRepository(MusicLabContext ctx) : ICompanyRepository
    {
        public List<Company> GetAll()
        {
            return ctx.Companies.ToList();

        }

        public List<Company> GetAllByMemberId(int memberId)
        {
            return ctx.Companies.Where(c => c.Members.Any(m => m.Id == memberId)).ToList();
        }
        public Company Add(Company c)
        {
            ctx.Companies.Add(c);
            ctx.SaveChanges();
            return c;
        }

        public Company? GetCompanyById(int id)
        {
            return ctx.Companies.SingleOrDefault(c => c.Id == id);
        }

        public bool ExistsGroup(string groupName)
        {
            return ctx.Companies.Any(m => m.Name == groupName);
        }

    }
}

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
        public virtual List<Company> GetAll()
        {
            return ctx.Companies.ToList();

        }
        public virtual Company Add(Company c)
        {
            ctx.Add(c);
            ctx.SaveChanges();
            return c;
        }
    }
}

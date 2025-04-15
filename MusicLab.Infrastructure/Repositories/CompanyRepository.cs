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
            //Faire join pour récupérer infos

        }
        public virtual Company Add(Company c)
        {
            ctx.Companies.Add(c);
            ctx.SaveChanges();
            return c;
        }

        public virtual Company? GetCompanyById(int id)
        {
            return ctx.Companies.SingleOrDefault(c => c.Id == id);
        }

        
    }
}

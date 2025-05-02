using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        //public void AddNewMemberToCompany(Company company)
        //{
        //    ctx.Companies.Update(company);
        //}

        public bool ExistsGroup(string groupName)
        {
            return ctx.Companies.Any(m => m.Name == groupName);
        }

        public Company? GetCompanyByIdWithMembers(int id)
        {
            return ctx.Companies.Include(c => c.Members).SingleOrDefault(c => c.Id == id);
        }
        public Company? GetCompanyByIdWithProjects(int id)
        {
            return ctx.Companies.Include(c => c.Projects).SingleOrDefault(c => c.Id == id);
        }

        public Company? GetCompanyByIdWithMembersAndProjects(int id)
        {
            return ctx.Companies.Include(c => c.Members).Include(c => c.Projects).SingleOrDefault(c => c.Id == id);
        }

        public void Update(Company company)
        {
            ctx.Update(company);
            ctx.SaveChanges();
        }
    }
}

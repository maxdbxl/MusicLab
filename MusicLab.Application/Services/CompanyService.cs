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
    public class CompanyService(ICompanyRepository companyRepository) : ICompanyService
    {
        public Company Create(CreateCompanyDTO dto)
        {
            Company c = companyRepository.Add(new Company
            {
                Name = dto.Name,
                Members = [],
                Projects = []
                
            });
            return c;
        }

        public Company GetById(int id) 
        {
            return companyRepository.GetCompanyById(id) ?? throw new KeyNotFoundException();
        }

        public List<Company> GetAll()
        {
            return companyRepository.GetAll();
        }

        public List<Company> GetAllByMemberId(int memberId)
        {
            return companyRepository.GetAllByMemberId(memberId);
        }

        public bool ExistsGroup(string groupName)
        {
            return companyRepository.ExistsGroup(groupName);
        }
    }
}

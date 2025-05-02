using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Services
{
    public class CompanyService(ICompanyRepository companyRepository, IMemberRepository memberRepository) : ICompanyService
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

        public Company GetById(int id, int connectedUserId) 
        {
            Company? company = companyRepository.GetCompanyByIdWithMembers(id);

            if (company!.Members.Any(m => m.Id == connectedUserId))
            {
                
                return companyRepository.GetCompanyByIdWithMembersAndProjects(id) ?? throw new KeyNotFoundException();
            }
            else
            {
                // éventuellement avec projets si besoin
                Company c = companyRepository.GetCompanyById(id) ?? throw new KeyNotFoundException();
                c.Members = [];
                return c;
            }

            
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

        public Company? GetCompanyByIdWithMembers(int id)
        {
            return companyRepository.GetCompanyByIdWithMembers(id);
        }

        public void AddMemberToCompany(int companyId, int memberId)
        {
            Company? company = companyRepository.GetCompanyByIdWithMembers(companyId);


            if (company == null)
            {
                throw new KeyNotFoundException();
            }

            Member? member = memberRepository.GetMemberById(memberId);

            if (member == null)
            {
                throw new KeyNotFoundException();
            }

            
            if (!company.Members.Any(m => m.Id == memberId))
            {
                company.Members.Add(member);
                companyRepository.Update(company);

            } else
            {
                throw new Exception("Le membre fait déjà partie du groupe");
            }

        }

        
    }
}

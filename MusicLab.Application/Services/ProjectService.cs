using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Services
{
    public class ProjectService(IProjectRepository projectRepository, ICompanyRepository companyRepository) : IProjectService
    {
        public Project Create(CreateProjectDTO dto, int ownerId)
        {
            Project p = projectRepository.Add(

                new Project
                {
                    Name = dto.Name,
                    Companies = dto.Companies.Select(id => companyRepository.GetCompanyById(id) ?? throw new Exception()).ToList(),
                    StartDate = dto.StartDate.HasValue ? dto.StartDate.Value : DateTime.Now,
                    EndDate = dto.EndDate,
                    OwnerId = ownerId,

                });
            return p;
        }

        public bool ExistsProject(string projectName)
        {
            return projectRepository.ExistsProject(projectName);
        }

        public List<Project> GetAll()
        {
            return projectRepository.GetAllProjects();
        }

        public Project GetById(int id)
        {
            return projectRepository.GetProjectById(id) ?? throw new KeyNotFoundException();
        }
    }
}

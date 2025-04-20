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
    public class ProjectService(IProjectRepository projectRepository) : IProjectService
    {
        public Project Create(CreateProjectDTO dto)
        {
            Project p = projectRepository.Add(

                new Project
                {
                    Name = dto.Name,
                    Companies = dto.Companies,
                    StartDate = dto.StartDate.HasValue ? dto.StartDate.Value : DateTime.Now,
                    EndDate = dto.EndDate
                });
            return p;
        }

        public bool ExistsProject(string projectName)
        {
            return projectRepository.ExistsProject(projectName);
        }

        public List<Project> GetAll()
        {
            throw new NotImplementedException();
        }

        public Project GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

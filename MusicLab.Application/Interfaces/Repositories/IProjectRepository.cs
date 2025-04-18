using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        Project Add(Project p);
        bool ExistsProject(string projectName);
        List<Project> GetAllProjects();
        Project? GetProjectById(int id);
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Repositories
{
    public class ProjectRepository(MusicLabContext ctx) : IProjectRepository
    {
        public Project Add(Project p)
        {
            ctx.Projects.Add(p);
            ctx.SaveChanges();
            return p;
        }

        public bool ExistsProject(string projectName)
        {
            return ctx.Projects.Any(p => p.Name == projectName);
        }

        public List<Project> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public Project? GetProjectById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

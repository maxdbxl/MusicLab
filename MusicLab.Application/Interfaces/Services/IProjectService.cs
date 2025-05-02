using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Services
{
    public interface IProjectService
    {
        Project Create(CreateProjectDTO dto, int ownerId);

        Project GetById(int id);

        List<Project> GetAll();

        bool ExistsProject(string projectName);
    }
}

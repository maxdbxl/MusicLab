using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Services
{
    public interface ICompanyService
    {
        Company Create(CreateCompanyDTO dto);

        Company GetById(int id);

        List<Company> GetAll();

        bool ExistsGroup(string group);

        List<Company> GetAllByMemberId(int memberId);

    }
}

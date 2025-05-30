﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.Interfaces.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetAll();

        List<Company> GetAllByMemberId(int memberId);
        Company Add(Company c);

        Company? GetCompanyById(int id);

        bool ExistsGroup(string groupName);
        Company? GetCompanyByIdWithMembers(int id);

    
        void Update(Company company);
        Company? GetCompanyByIdWithMembersAndProjects(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.DTO
{
    public class CompanyDTO(Company company)
    {
        public int Id { get; set; } = company.Id;
        public string Name { get; set; } = company.Name;
        public List<MemberDTO> Members { get; set; } = company.Members.Select(m => new MemberDTO(m)).ToList();
        //public List<Project> Projects { get; set; } = null!;



    }
}

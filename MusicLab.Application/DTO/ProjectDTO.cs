using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.DTO
{
    public class ProjectDTO(Project project)
    {
        public int Id { get; set; } = project.Id;
        public string Name { get; set; } = project.Name;
        //public List<Company> Companies { get; set; } = project.Companies;
        //public List<Meeting> Meetings { get; set; } = project.Meetings;
        public int OwnerId { get; set; } = project.OwnerId;
        public MemberDTO Owner { get; set; } = project.Owner != null ? new MemberDTO(project.Owner) : null!;
        public DateTime StartDate { get; set; } = project.StartDate;
        public DateTime UpdateDate { get; set; } = project.UpdateDate;
        public DateTime EndDate { get; set; } = project.EndDate;
    }
}

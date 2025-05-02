using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLab.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Member> Members { get; set; } = [];
        public List<Project> Projects { get; set; } = [];

    }
}

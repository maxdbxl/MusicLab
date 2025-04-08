using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLab.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Company> Companies { get; set; } = null!;
        //public List<Meeting> Meetings { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

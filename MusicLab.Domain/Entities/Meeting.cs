using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLab.Domain.Entities
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location  { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public List<Invitation> Invitations { get; set; } = null!;
    }
}

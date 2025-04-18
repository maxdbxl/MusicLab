using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;

namespace MusicLab.Application.DTO
{
    public class CreateProjectDTO
    {
        public string Name { get; set; } = null!;

        public List<Company> Companies { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

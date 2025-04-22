using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Configs
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.ToTable(t => t.HasCheckConstraint("CK_CompareDates", "startDate < endDate"));

            //builder.Property(p => p.Companies).IsRequired();

            builder.HasData([
                new Project {
                    Id = 1,
                    Name = "Dear Evan Hansen",
                    StartDate = new DateTime(2025, 5, 10),
                    UpdateDate = new DateTime(2025, 4, 18),
                    EndDate = new DateTime(2025, 8, 30),
                    OwnerId = 1
                }
                ]);
        }
    }
}

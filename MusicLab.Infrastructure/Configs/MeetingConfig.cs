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
    public class MeetingConfig : IEntityTypeConfiguration<Meeting>
    {
        public void Configure(EntityTypeBuilder<Meeting> builder) 
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(350);
            builder.Property(m => m.Description).HasMaxLength(1500);

            builder.HasData([
                new Meeting {
                    Id = 1,
                    Name = "Répétition du mercredi",
                    Description = "répétition chorégraphie, amenez vos chaussures",
                    Location = "Local C1",
                    StartTime = new DateTime(2025, 5, 11, 18, 30, 0),
                    EndTime = new DateTime(2025, 5, 11, 21, 0, 0),
                    EventType = Domain.Enums.EventType.Repetition,
                    ProjectId = 1
                },
                new Meeting {
                    Id = 2,
                    Name = "Répétition du jeudi",
                    Description = "répétition chant",
                    Location = "Local B3",
                    StartTime = new DateTime(2025, 5, 12, 18, 30, 0),
                    EndTime = new DateTime(2025, 5, 12, 21, 0, 0),
                    EventType= Domain.Enums.EventType.Repetition,
                    ProjectId = 1
                }
                ]);
        }
    }
}

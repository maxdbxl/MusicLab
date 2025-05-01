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
    public class PersonalEventConfig : IEntityTypeConfiguration<PersonalEvent>
    {
        public void Configure(EntityTypeBuilder<PersonalEvent> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(450);

            builder.HasData([
                new PersonalEvent {
                    Id = 1,
                    Name = "Palais des thés",
                    Description = "Remplacement Gaby",
                    Location = "Boutique Louise",
                    StartTime = new DateTime(2025, 5, 12, 9, 30, 0),
                    EndTime = new DateTime(2025, 5, 12, 17, 0, 0),
                    EventType = Domain.Enums.EventType.PersonalEvent,
                    MemberId = 1
                },
                new PersonalEvent {
                    Id = 2,
                    Name = "Resto AICOM",
                    Description = "Resto fin des exams",
                    Location = "Nona Mérode",
                    StartTime = new DateTime(2025, 5, 12, 21, 15, 0),
                    EndTime = new DateTime(2025, 5, 12, 22, 30, 0),
                    EventType = Domain.Enums.EventType.PersonalEvent,
                    MemberId = 1
                },
                new PersonalEvent {
                    Id = 3,
                    Name = "Resto AICOM",
                    Description = "Resto fin des exams",
                    Location = "Nona Mérode",
                    StartTime = new DateTime(2025, 5, 12, 21, 15, 0),
                    EndTime = new DateTime(2025, 5, 12, 22, 30, 0),
                    EventType = Domain.Enums.EventType.PersonalEvent,
                    MemberId = 2
                }
                ]);
        }
    }
}

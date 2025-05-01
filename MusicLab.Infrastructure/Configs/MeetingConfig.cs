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
                    StartTime = new DateTime(2025, 5, 14, 18, 30, 0),
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
                },
                new Meeting {
                    Id = 3,
                    Name = "Atelier mise en scène",
                    Description = "Travail sur la mise en scène de l'acte 2",
                    Location = "Salle Polyvalente",
                    StartTime = new DateTime(2025, 5, 14, 14, 0, 0),
                    EndTime = new DateTime(2025, 5, 14, 17, 30, 0),
                    EventType = Domain.Enums.EventType.Repetition,
                    ProjectId = 1
                },

                new Meeting {
                    Id = 4,
                    Name = "Répétition générale",
                    Description = "Répétition complète avec costumes et décors",
                    Location = "Théâtre Municipal",
                    StartTime = new DateTime(2025, 5, 18, 19, 0, 0),
                    EndTime = new DateTime(2025, 5, 18, 22, 0, 0),
                    EventType = Domain.Enums.EventType.Repetition,
                    ProjectId = 1
                },

                new Meeting {
                    Id = 5,
                    Name = "Auditions complémentaires",
                    Description = "Sélection pour les seconds rôles",
                    Location = "Studio 1",
                    StartTime = new DateTime(2025, 5, 10, 10, 0, 0),
                    EndTime = new DateTime(2025, 5, 10, 13, 0, 0),
                    EventType = Domain.Enums.EventType.Other,
                    ProjectId = 1
                },

                new Meeting {
                    Id = 6,
                    Name = "Représentation publique",
                    Description = "Première représentation de la comédie musicale",
                    Location = "Théâtre de la Ville",
                    StartTime = new DateTime(2025, 5, 24, 20, 30, 0),
                    EndTime = new DateTime(2025, 5, 24, 23, 0, 0),
                    EventType = Domain.Enums.EventType.Performance,
                    ProjectId = 1
                },
                new Meeting {
                    Id = 7,
                    Name = "Réunion Budget & Communication",
                    Description = "Présentation du budget, point sur les sponsors et choix des affiches",
                    Location = "Salle B3",
                    StartTime = new DateTime(2025, 5, 15, 20, 30, 0),
                    EndTime = new DateTime(2025, 5, 15, 23, 0, 0),
                    EventType = Domain.Enums.EventType.OrganizationalMeeting,
                    ProjectId = 1
                },
                new Meeting {
                    Id = 8,
                    Name = "Rencontre de l'équipe technique",
                    Description = "Visite coulisses & scène, vérification matos",
                    Location = "Théâtre de la Ville",
                    StartTime = new DateTime(2025, 5, 15, 15, 30, 0),
                    EndTime = new DateTime(2025, 5, 15, 17, 30, 0),
                    EventType = Domain.Enums.EventType.LogisticsMeeting,
                    ProjectId = 1
                }

                ]);
        }
    }
}

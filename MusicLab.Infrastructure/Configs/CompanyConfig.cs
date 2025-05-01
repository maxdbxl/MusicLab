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
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder) 
        {
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(c => c.Name).IsUnique();

            builder.HasData([
                new Company {
                    Id = 1,
                    Name = "Los Branches"
                },
                new Company {
                    Id = 2,
                    Name = "AICOM"
                },
                new Company {
                    Id = 3,
                    Name = "Compagnie Dalché"
                },
                new Company {
                    Id = 4,
                    Name = "Brussels Musical Creative"
                }
                ]);

        }
    }
}

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
    public class MemberConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.Username)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(m => m.Username).IsUnique();
            builder.HasIndex(m => m.Email).IsUnique();

            builder.HasData([
                new Member {
                    Id = 1,
                    Username = "Henrie",
                    Email = "henrie@branche.be",
                    Role = Domain.Enums.Role.Admin,
                    Password = "Test1234!"
              
                },
                new Member {
                    Id = 2,
                    Username = "Mireillle",
                    Email = "mireille@branche.be",
                    Role = Domain.Enums.Role.Member,
                    Password = "Test1234!"
                }
                ]);

        }
    }
}

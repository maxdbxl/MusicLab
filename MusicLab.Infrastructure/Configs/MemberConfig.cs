using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicLab.Application.Utils;
using MusicLab.Domain.Entities;

namespace MusicLab.Infrastructure.Configs
{
    public class MemberConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            Guid guid = new("5ef564cb-6596-4592-b7bc-f21db73e1765");
            Guid guid2 = new("93f1883a-2735-4595-adbc-059acb879af6");

            builder.Property(m => m.Username)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(m => m.Username).IsUnique();
            builder.HasIndex(m => m.Email).IsUnique();
            builder.Property(m => m.Salt).IsRequired();

            builder.HasData([
                new Member {
                    Id = 1,
                    Username = "Henrie",
                    Email = "henrie@branche.be",
                    Role = Domain.Enums.Role.Admin,
                    Password = PasswordUtils.HashPassword("Test1234!", guid),
                    Salt = guid
              
                },
                new Member {
                    Id = 2,
                    Username = "Mireillle",
                    Email = "mireille@branche.be",
                    Role = Domain.Enums.Role.Member,
                    Password = PasswordUtils.HashPassword("Test1234!", guid2),
                    Salt = guid2
                }
                ]);

        }
    }
}

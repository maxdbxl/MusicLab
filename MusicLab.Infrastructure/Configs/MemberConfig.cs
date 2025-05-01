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
            Guid guid3 = new("bad0da15-86e8-4a7d-b310-880842b11982");
            Guid guid4 = new("d184818a-aef1-4357-ab08-4cd1aecbac70");
            Guid guid5 = new("157e0e7f-4ead-46f4-9c49-a663c89e181a");

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
                    Username = "Mireille",
                    Email = "mireille@branche.be",
                    Role = Domain.Enums.Role.Member,
                    Password = PasswordUtils.HashPassword("Test1234!", guid2),
                    Salt = guid2
                },
                new Member {
                    Id = 3,
                    Username = "Jeanine",
                    Email = "jeanine@branche.be",
                    Role = Domain.Enums.Role.Member,
                    Password = PasswordUtils.HashPassword("Test1234!", guid3),
                    Salt = guid2
                },
                new Member {
                    Id = 4,
                    Username = "Colette",
                    Email = "colette@branche.be",
                    Role = Domain.Enums.Role.Member,
                    Password = PasswordUtils.HashPassword("Test1234!", guid4),
                    Salt = guid2
                },
                new Member {
                    Id = 5,
                    Username = "Lison",
                    Email = "lison@branche.be",
                    Role = Domain.Enums.Role.Member,
                    Password = PasswordUtils.HashPassword("Test1234!", guid5),
                    Salt = guid2
                },
                ]);

        }
    }
}

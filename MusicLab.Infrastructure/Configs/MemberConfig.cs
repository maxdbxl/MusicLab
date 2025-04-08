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
            builder.Property(c => c.Username)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(c => c.Username).IsUnique();

        }
    }
}

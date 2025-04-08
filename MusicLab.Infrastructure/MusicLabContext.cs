using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicLab.Domain.Entities;
using MusicLab.Infrastructure.Configs;

namespace MusicLab.Infrastructure
{
    public class MusicLabContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MemberConfig());
            modelBuilder.ApplyConfiguration(new CompanyConfig());
        }
    }
}

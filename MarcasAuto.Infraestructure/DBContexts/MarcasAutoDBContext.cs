using MarcasAuto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MarcasAuto.Infraestructure.DBContexts
{
    public class MarcasAutoDBContext : DbContext
    {
        public DbSet<MarcasAutoEntity> Blogs { get; set; }

        public MarcasAutoDBContext(DbContextOptions<MarcasAutoDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // MarcasAutoEntity
            builder.Entity<MarcasAutoEntity>().ToTable("MarcasAuto");
            builder.Entity<MarcasAutoEntity>().HasIndex(e => e.Id);
            builder.Entity<MarcasAutoEntity>().Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Entity<MarcasAutoEntity>().Property(e => e.Make).IsRequired();

            // Seed
            builder.Entity<MarcasAutoEntity>().HasData(
                new MarcasAutoEntity { Id = "8901d8dd-24b0-4f56-a523-6d6694b9a4ac", Make = "Toyota" },
                new MarcasAutoEntity { Id = "91de0725-5e4d-49af-b63d-1dfc6b7699c9", Make = "Ford" },
                new MarcasAutoEntity { Id = "ff5425c0-ed1d-422d-ad1d-47a1e5f8b8f1", Make = "Chevrolet" });
        }
    }
}

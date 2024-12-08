using MarcasAuto.Domain.Entities;
using MarcasAuto.Infraestructure.Seeds;
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
        public DbSet<MarcasAutoEntity> MarcasAuto { get; set; }

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
            builder.Entity<MarcasAutoEntity>().HasData(MarcasSeed.Items);
        }
    }
}

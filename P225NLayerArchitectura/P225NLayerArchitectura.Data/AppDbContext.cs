using Microsoft.EntityFrameworkCore;
using P225NLayerArchitectura.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Data
{
    public class AppDbContext : DbContext
    {
        //dotnet ef --startup-project ..\P225NLayerArchitectura.Api migrations add InitialCreate
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}

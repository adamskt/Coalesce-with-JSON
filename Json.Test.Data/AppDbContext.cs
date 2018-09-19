using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Json.Test.Data.Models;
using IntelliTect.Coalesce;

namespace Json.Test.Data
{
    [Coalesce]
    public class AppDbContext : DbContext
    {
        public DbSet<LiveAudit> LiveAudits { get; set; }
        public DbSet<PostInstallAudit> PostInstallAudits { get; set; }
        public DbSet<ElectricMeterExchange> ElectricMeterExchanges { get; set; }
        public DbSet<GasRetrofit> GasRetrofits { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Remove cascading deletes.
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<FieldWork>()
                .Property("Discriminator")
                .HasMaxLength(50);

            builder.Entity<Inspection>()
                .Property("Discriminator")
                .HasMaxLength(50);

        }

        /// <summary>
        /// Migrates the database and sets up items that need to be set up from scratch.
        /// </summary>
        public void Initialize()
        {
            try
            {
                this.Database.Migrate();
            }
            catch (InvalidOperationException e) when (e.Message == "No service for type 'Microsoft.EntityFrameworkCore.Migrations.IMigrator' has been registered.")
            {
                // this exception is expected when using an InMemory database
            }
        }
    }
}

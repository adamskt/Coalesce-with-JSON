using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Json.Test.Data
{
    public class DevelopmentAppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // This is only used when adding migrations and updating the database from the cmd line.
            // It shouldn't ever be used in code where it might end up running in production.
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer("Data Source=mjolnir;Initial Catalog=Json_TestDB;Persist Security Info=True;User ID=sa;Password=D3@dB33f;Pooling=False;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True");
            return new AppDbContext(builder.Options);
        }
    }
}

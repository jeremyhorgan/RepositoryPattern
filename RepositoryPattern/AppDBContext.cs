using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Model;

namespace RepositoryPattern
{
    internal class AppDBContext : DbContext
    {
        public DbSet<Scenario> Scenarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=(local)\SQLExpress;Database=Test2;Trusted_Connection=True;");
        }
    }
}
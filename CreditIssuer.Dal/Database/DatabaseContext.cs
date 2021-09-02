using CreditIssuer.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace CreditIssuer.Dal.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<CreditRequest> CreditRequests { get; set; }
        public DbSet<RequestedCredit> RequestedCredits { get; set; }
        public DbSet<CreditManager> CreditManagers { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {            
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DatabaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\v12.0;Database=creditDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
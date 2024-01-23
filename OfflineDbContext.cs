using Microsoft.EntityFrameworkCore;
using Offline_System.Models.Data;

namespace Offline_System {
    public class OfflineDbContext : DbContext {
        private readonly string dbHost = "sql.bsite.net\\MSSQL2016";
        private readonly string dbName = "arctic_SampleDB";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer($"Server={dbHost};Database={dbName};User Id=arctic_SampleDB;Password=BBU@2024;Trusted_Connection=true;TrustServerCertificate=true;Encrypt=false;Integrated Security=false");
        }
        public DbSet<Employees> ContEmployee { get; set; }
        public DbSet<Departments> ContDepart { get; set; }
        public DbSet<Positions> ContPos { get; set; }
    }
}

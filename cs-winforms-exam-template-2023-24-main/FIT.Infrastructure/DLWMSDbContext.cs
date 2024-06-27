using FIT.Data;
using FIT.Data.IB220229;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        private readonly string dbPutanja;

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
    
        public DbSet<Student> Studenti { get; set; }
        public DbSet<NastavaIB220229> Nastava { get; set; }
        public DbSet<PredmetIB220229> Predmet { get; set; }
        public DbSet<PrisustvoIB220229> Prisustvo { get; set; }
        public DbSet<ProstorijeIB220229> Prostorije { get; set; }



    }
}
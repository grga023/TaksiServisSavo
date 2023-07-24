using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiServis.Modeli;

namespace TaksiServis.Repozitoriumi.Context
{
    public class TaksiDBCotext : DbContext
    {
        public TaksiDBCotext()
        {

        }
        public TaksiDBCotext(DbContextOptions<TaksiDBCotext> options) : base(options)
        {
        }
        public DbSet<Vozilo> Vozilo => Set<Vozilo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GRGA\\SQLEXPRESS;Initial Catalog=Filmovi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<City>().HasData(
            //    new City()
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "Ankara",
            //        Population = "5.663.000",
            //    },
            //    new City
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "İstanbul",
            //        Population = "15.460.000"
            //    },
            //    new City
            //    {
            //        Id = Guid.NewGuid(),
            //        Name = "İzmir",
            //        Population = "4.321.000"
            //    }
            //);

            base.OnModelCreating(modelBuilder);
        }
    }
}

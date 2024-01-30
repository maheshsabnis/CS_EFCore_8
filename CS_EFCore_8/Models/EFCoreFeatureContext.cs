using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_EFCore_8.Models
{
    internal class EFCore8FeatureContext : DbContext
    {
        public EFCore8FeatureContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFCore8Feature;Integrated Security=SSPI;TrustServerCertificate=True");
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<BirthRecord> BirthRecord { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ComplexProperty(c => c.Address);

            modelBuilder.Entity<BirthRecord>().HasData(new BirthRecord() 
            {
                BirthId = 1,
                BirthName = "Ganesh",
                DateOfBirth = new DateOnly(2022,1,1),
                TimeOfBirth = new TimeOnly(1,0,0)
            });

            //modelBuilder.Entity<Person>().HasData(
            //     new Person()
            //     {
            //         PersonId = 1,
            //         PersonName = "Mahesh Sabnis",
            //         Address = new Address()
            //         {
            //             FlatOrBungloNo = "A-901-X-Society",
            //             Street = "Unknown Road",
            //             City = "Unpredicatable",
            //             PinCode = "4545444"
            //         }
            //     }
            //    );
        }
    }
}

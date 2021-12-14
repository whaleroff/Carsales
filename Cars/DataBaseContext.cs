using System.Data.Entity;
using Cars.Models;

namespace Cars
{
    public class DataBaseContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cinsurance> Cinsurances { get; set; }
        public DbSet<Parts> PartsEnumerable { get; set; }
        public DbSet<Police> Polices { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataLayer.Models.Mapping;

namespace DataLayer.Models
{
    public partial class ForoshContext : DbContext
    {
        static ForoshContext()
        {
            Database.SetInitializer<ForoshContext>(null);
        }

        public ForoshContext()
            : base("Name=ForoshContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TbGroup> TbGroups { get; set; }
        public DbSet<TbProduct> TbProducts { get; set; }
        public DbSet<TbUnit> TbUnits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TbGroupMap());
            modelBuilder.Configurations.Add(new TbProductMap());
            modelBuilder.Configurations.Add(new TbUnitMap());
        }
    }
}

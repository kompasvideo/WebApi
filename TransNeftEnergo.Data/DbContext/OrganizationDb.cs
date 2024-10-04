using Microsoft.EntityFrameworkCore;
using TransNeftEnergo.Data.Entity;

namespace TransNeftEnergo.Data
{
    public class OrganizationDb : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<SubsidiaryOrganization> SubsidiaryOrganizations { get; set; }
        public DbSet<ObjectOfConsumption> ObjectOfConsumptions { get; set; }
        public DbSet<ElectricitySupplyPoint> ElectricitySupplyPoints { get; set; }
        public DbSet<CalculationDevice> CalculationDevices { get; set; }
        public DbSet<ElectricityMeasurementPoint> ElectricityMeasurementPoints { get; set; }
        public DbSet<ElectricEnergyMeter> ElectricEnergyMeters { get; set; }
        public DbSet<CurrentTransformer> CurrentTransformers { get; set; }
        public DbSet<VoltageTransformer> VoltageTransformers { get; set; }
        public DbSet<AccountingPeriod> AccountingPeriods { get; set; }

        public OrganizationDb(DbContextOptions<OrganizationDb> options) : base(options) { }
        static OrganizationDb() {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<AccountingPeriod>().HasKey(p => new { p.CalculationDeviceKey, p.ElectricityMeasurementPointKey });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ElectricityAccounting;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}

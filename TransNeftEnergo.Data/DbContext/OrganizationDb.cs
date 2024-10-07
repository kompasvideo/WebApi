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
            modelBuilder
                .Entity<CalculationDevice>()
                .HasMany(c => c.ElectricityMeasurementPoints)
                .WithMany(e => e.CalculationDevices)
                .UsingEntity<AccountingPeriod>(
                    a => a
                    .HasOne(b => b.ElectricityMeasurementPoint)
                    .WithMany(d => d.AccountingPeriods)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(b => b.ElectricityMeasurementPointId),
                    a => a
                    .HasOne(b => b.CalculationDevice)
                    .WithMany(f => f.AccountingPeriods)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasForeignKey(b => b.CalculationDeviceId),
                    a =>
                    {
                        a.Property(b => b.StartDate).HasDefaultValue(new DateTime());
                        a.Property(b => b.EndDate).HasDefaultValue(new DateTime());
                        a.HasKey(t => new { t.CalculationDeviceId, t.ElectricityMeasurementPointId });
                        a.ToTable("AccountingPeriod");
                    });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ElectricityAccounting;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}

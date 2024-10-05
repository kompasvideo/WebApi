namespace TransNeftEnergo.Data.Entity
{
    // объект потребления
    public class ObjectOfConsumption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int SubsidiaryOrganizationId { get; set; }
        public SubsidiaryOrganization? SubsidiaryOrganization { get; set; }

        public List<ElectricitySupplyPoint> ElectricitySupplyPoints { get; set; } = new();
        public List<ElectricityMeasurementPoint> ElectricityMeasurementPoints { get; set; } = new();
    }
}

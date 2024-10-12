namespace TransNeftEnergo.Core.Entity
{
    // объект потребления
    public class ObjectOfConsumptionDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int? SubsidiaryOrganizationId { get; set; }
        public SubsidiaryOrganizationDto? SubsidiaryOrganization { get; set; }

        public List<ElectricitySupplyPointDto?>? ElectricitySupplyPoints { get; set; } = new();
        public List<ElectricityMeasurementPointDto?>? ElectricityMeasurementPoints { get; set; } = new();
    }
}

namespace TransNeftEnergo.Core.Entity
{
    // расчётный прибор учёта
    public class CalculationDeviceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElectricitySupplyPointId { get; set; }
        public ElectricitySupplyPointDto? ElectricitySupplyPoint { get; set; }
        public List<ElectricityMeasurementPointDto?> ElectricityMeasurementPoints { get; set; } = new();
        public List<AccountingPeriodDto?> AccountingPeriods { get; set; } = new();
    }
}

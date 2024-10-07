namespace TransNeftEnergo.Core.Entity
{
    // точка измерения электроэнергии
    public class ElectricityMeasurementPointDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ObjectOfConsumptionId { get; set; }
        public ObjectOfConsumptionDto? ObjectOfConsumption { get; set; }

        public List<CalculationDeviceDto?> CalculationDevices { get; set; } = new();
        public List<AccountingPeriodDto?> AccountingPeriods { get; set; } = new();
        public ElectricEnergyMeterDto? ElectricEnergyMeter { get; set; }
        public CurrentTransformerDto? CurrentTransformer { get; set; }
        public VoltageTransformerDto? VoltageTransformer { get; set; }
    }
}

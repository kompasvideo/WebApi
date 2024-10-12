namespace TransNeftEnergo.Data.Entity
{
    // точка измерения электроэнергии
    public class ElectricityMeasurementPoint
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? ObjectOfConsumptionId { get; set; }
        public ObjectOfConsumption? ObjectOfConsumption { get; set; }

        public List<CalculationDevice?>? CalculationDevices { get; set; } = new();
        public List<AccountingPeriod?>? AccountingPeriods { get; set; } = new();
        public ElectricEnergyMeter? ElectricEnergyMeter { get; set; }
        public CurrentTransformer? CurrentTransformer { get; set; }
        public VoltageTransformer? VoltageTransformer { get; set; }
    }
}

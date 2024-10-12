namespace TransNeftEnergo.Data.Entity
{
    // расчётный прибор учёта
    public class CalculationDevice
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? ElectricitySupplyPointId { get; set; }
        public ElectricitySupplyPoint? ElectricitySupplyPoint { get; set; }
        public List<ElectricityMeasurementPoint?>? ElectricityMeasurementPoints { get; set; } = new();
        public List<AccountingPeriod?>? AccountingPeriods { get; set; } = new();
    }
}

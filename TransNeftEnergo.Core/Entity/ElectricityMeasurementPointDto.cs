namespace TransNeftEnergo.Core.Entity
{
    // точка измерения электроэнергии
    public class ElectricityMeasurementPointDto
    {
        public int ElectricityMeasurementPointId { get; set; }
        public string Name { get; set; }
        public int ObjectOfConsumptionKey { get; set; }
        public ObjectOfConsumptionDto ObjectOfConsumption { get; set; }
        public int AccountingPeriodKey { get; set; }
        public AccountingPeriodDto AccountingPeriod { get; set; }
    }
}

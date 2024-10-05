namespace TransNeftEnergo.Data.Entity
{
    // точка измерения электроэнергии
    public class ElectricityMeasurementPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ObjectOfConsumptionId { get; set; }
        public ObjectOfConsumption? ObjectOfConsumption { get; set; }
        //public int AccountingPeriodId { get; set; }
        //public AccountingPeriod? AccountingPeriod { get; set; }
        public List<AccountingPeriod?> AccountingPeriods { get; set; }

        public ElectricEnergyMeter? ElectricEnergyMeter { get; set; }
        public CurrentTransformer? CurrentTransformer { get; set; }
        public VoltageTransformer? VoltageTransformer { get; set; }
    }
}

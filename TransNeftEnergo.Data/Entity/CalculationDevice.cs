namespace TransNeftEnergo.Data.Entity
{
    // расчётный прибор учёта
    public class CalculationDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElectricitySupplyPointId { get; set; }
        public ElectricitySupplyPoint? ElectricitySupplyPoint { get; set; }
        //public int AccountingPeriodId { get; set; }
        //public AccountingPeriod? AccountingPeriod { get; set; }
        public List<AccountingPeriod?> AccountingPeriods { get; set; }
    }
}

namespace TransNeftEnergo.Data.Entity
{
    // точка поставки электроэнергии
    public class ElectricitySupplyPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MaxPower { get; set; }
        public int ObjectOfConsumptionId { get; set; }
        public ObjectOfConsumption? ObjectOfConsumption { get; set; }

        public List<CalculationDevice> CalculationDevices { get; set; } = new();
    }
}

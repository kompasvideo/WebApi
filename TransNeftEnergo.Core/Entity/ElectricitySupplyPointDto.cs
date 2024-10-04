namespace TransNeftEnergo.Core.Entity
{
    // точка поставки электроэнергии
    public class ElectricitySupplyPointDto
    {
        public int ElectricitySupplyPointId { get; set; }
        public string Name { get; set; }
        public float MaxPower { get; set; }
        public int ObjectOfConsumptionKey { get; set; }
        public ObjectOfConsumptionDto ObjectOfConsumption { get; set; }
    }
}

namespace TransNeftEnergo.Core.Entity
{
    // точка поставки электроэнергии
    public class ElectricitySupplyPointDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MaxPower { get; set; }
        public int ObjectOfConsumptionId { get; set; }
        public ObjectOfConsumptionDto? ObjectOfConsumption { get; set; }

        public List<CalculationDeviceDto> CalculationDevices { get; set; } = new();
    }
}

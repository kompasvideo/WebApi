namespace TransNeftEnergo.Core.Requests
{
    // точка измерения электроэнергии
    public class ElectricityMeasurementPointReq
    {
        public string Name { get; set; }
        public ElectricEnergyMeterReq ElectricEnergyMeter { get; set; }
        public CurrentTransformerReq CurrentTransformer { get; set; }
        public VoltageTransformerReq VoltageTransformer { get; set; }
    }
}

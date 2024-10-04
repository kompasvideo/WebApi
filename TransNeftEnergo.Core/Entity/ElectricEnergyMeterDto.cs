using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Entity
{
    // счётчик электрической энергии
    public class ElectricEnergyMeterDto
    {
        public int ElectricEnergyMeterId { get; set; }
        public string Name { get; set; }
        public MeterType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        public ElectricityMeasurementPointDto ElectricityMeasurementPoint { get; set; }

    }
}

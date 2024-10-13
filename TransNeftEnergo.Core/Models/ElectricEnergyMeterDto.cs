using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Entity
{
    // счётчик электрической энергии
    public class ElectricEnergyMeterDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public MeterType? Type { get; set; }
        public DateTime? VerificationDate { get; set; }
        public int? ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPointDto? ElectricityMeasurementPoint { get; set; }
    }
}

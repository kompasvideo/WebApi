using TransNeftEnergo.Data.Enums;

namespace TransNeftEnergo.Data.Entity
{
    // счётчик электрической энергии
    public class ElectricEnergyMeter
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public MeterType? Type { get; set; }
        public DateOnly? VerificationDate { get; set; }
        public int? ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPoint? ElectricityMeasurementPoint { get; set; }
    }
}

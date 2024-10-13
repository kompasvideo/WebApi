using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Entity
{
    // трансформатор тока
    public class CurrentTransformerDto
    {
        public int? Id { get; set; }
        public string? Number { get; set; }
        public CurrentTransformerType? Type { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string? KTT { get; set; }
        public int? ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPointDto? ElectricityMeasurementPoint { get; set; }
    }
}

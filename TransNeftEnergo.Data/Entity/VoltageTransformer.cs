using TransNeftEnergo.Data.Enums;

namespace TransNeftEnergo.Data.Entity
{
    // трансформатор напряжения
    public class VoltageTransformer
    {
        public int? Id { get; set; }
        public string? Number { get; set; }
        public VoltageTransformerType? Type { get; set; }
        public DateTime? VerificationDate { get; set; }
        public string? KTN { get; set; }
        public int? ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPoint? ElectricityMeasurementPoint { get; set; }
    }
}

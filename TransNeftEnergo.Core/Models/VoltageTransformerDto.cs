using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Entity
{
    // трансформатор напряжения
    public class VoltageTransformerDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public VoltageTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public string KTN { get; set; }
        public int ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPointDto ElectricityMeasurementPoint { get; set; }
    }
}

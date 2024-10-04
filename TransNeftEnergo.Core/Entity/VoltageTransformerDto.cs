using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Entity
{
    // трансформатор напряжения
    public class VoltageTransformerDto
    {
        public int VoltageTransformerId { get; set; }
        public string Number { get; set; }
        public VoltageTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public float KTN { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        public ElectricityMeasurementPointDto ElectricityMeasurementPoint { get; set; }
    }
}

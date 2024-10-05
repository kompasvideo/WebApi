using TransNeftEnergo.Data.Enums;

namespace TransNeftEnergo.Data.Entity
{
    // трансформатор тока
    public class CurrentTransformer
    {
        public int Id { get; set; }
        public decimal Number { get; set; }
        public CurrentTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public string KTT { get; set; }
        public int ElectricityMeasurementPointId { get; set; }
        public ElectricityMeasurementPoint ElectricityMeasurementPoint { get; set; }
    }
}

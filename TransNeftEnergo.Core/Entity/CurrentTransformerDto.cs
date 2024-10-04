using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransNeftEnergo.Core.Enums;

namespace TransNeftEnergo.Core.Entity
{
    // трансформатор тока
    public class CurrentTransformerDto
    {
        public int CurrentTransformerId { get; set; }
        public string Number { get; set; }
        public CurrentTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public float KTT { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        public ElectricityMeasurementPointDto ElectricityMeasurementPoint { get; set; }
    }
}

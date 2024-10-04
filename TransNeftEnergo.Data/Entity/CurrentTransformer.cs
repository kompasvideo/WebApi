using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransNeftEnergo.Data.Enums;

namespace TransNeftEnergo.Data.Entity
{
    // трансформатор тока
    public class CurrentTransformer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CurrentTransformerId { get; set; }
        public string Number { get; set; }
        public CurrentTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public float KTT { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        [ForeignKey("ElectricityMeasurementPointKey")]
        public ElectricityMeasurementPoint ElectricityMeasurementPoint { get; set; }
    }
}

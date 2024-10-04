using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransNeftEnergo.Data.Enums;

namespace TransNeftEnergo.Data.Entity
{
    // трансформатор напряжения
    public class VoltageTransformer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VoltageTransformerId { get; set; }
        public string Number { get; set; }
        public VoltageTransformerType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public float KTN { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        [ForeignKey("ElectricityMeasurementPointKey")]
        public ElectricityMeasurementPoint ElectricityMeasurementPoint { get; set; }

    }
}

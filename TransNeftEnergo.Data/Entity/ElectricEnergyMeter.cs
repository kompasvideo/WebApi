using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransNeftEnergo.Data.Enums;

namespace TransNeftEnergo.Data.Entity
{
    // счётчик электрической энергии
    public class ElectricEnergyMeter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ElectricEnergyMeterId { get; set; }
        public string Name { get; set; }
        public MeterType Type { get; set; }
        public DateTime VerificationDate { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        [ForeignKey("ElectricityMeasurementPointKey")]
        public ElectricityMeasurementPoint ElectricityMeasurementPoint { get; set; }

    }
}

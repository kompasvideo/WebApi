using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransNeftEnergo.Data.Entity
{
    public class AccountingPeriod
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountingPeriodId { get; set; }
        public int CalculationDeviceKey { get; set; }
        [ForeignKey("CalculationDeviceKey")]
        public CalculationDevice CalculationDevice { get; set; }
        public int ElectricityMeasurementPointKey { get; set; }
        [ForeignKey("ElectricityMeasurementPointKey")]
        public ElectricityMeasurementPoint ElectricityMeasurementPoint { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

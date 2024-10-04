using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergo.Data.Entity
{
    // расчётный прибор учёта
    public class CalculationDevice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ElectricitySupplyPointId { get; set; }
        public string Name { get; set; }
        public int ElectricitySupplyPointKey { get; set; }
        [ForeignKey("ElectricitySupplyPointKey")]
        public ElectricitySupplyPoint ElectricitySupplyPoint { get; set; }
        public int AccountingPeriodKey { get; set; }
        [ForeignKey("AccountingPeriodKey")]
        public AccountingPeriod AccountingPeriod { get; set; }
    }
}

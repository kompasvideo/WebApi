using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransNeftEnergo.Core.Entity
{
    // расчётный прибор учёта
    public class CalculationDeviceDto
    {
        public int ElectricitySupplyPointId { get; set; }
        public string Name { get; set; }
        public int ElectricitySupplyPointKey { get; set; }
        public ElectricitySupplyPointDto ElectricitySupplyPoint { get; set; }
        public int AccountingPeriodKey { get; set; }
        public AccountingPeriodDto AccountingPeriod { get; set; }
    }
}
